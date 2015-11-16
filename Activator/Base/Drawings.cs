using System;
using System.Drawing;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Base
{
    class Drawings
    {
        public static void Init()
        {
            Drawing.OnDraw += args =>
            {
                if (Activator.Origin.Item("acdebug").GetValue<bool>())
                {
                    foreach (var hero in Activator.Allies())
                    {
                        var mpos = Drawing.WorldToScreen(hero.Player.Position);

                        if (!hero.Player.IsDead)
                        {
                            Drawing.DrawText(mpos[0] - 40, mpos[1] - 15, Color.White, "Income Damage: " + hero.IncomeDamage);
                            Drawing.DrawText(mpos[0] - 40, mpos[1] + 0, Color.White, "Income Percent: " + hero.IncomeDamage / hero.Player.MaxHealth * 100);
                            Drawing.DrawText(mpos[0] - 40, mpos[1] + 15, Color.White, "QSSBuffCount: " + hero.QSSBuffCount);
                            Drawing.DrawText(mpos[0] - 40, mpos[1] + 30, Color.White, "QSSHighestBuffTime: " + hero.QSSHighestBuffTime);
                        }


                        Drawing.DrawText(200f, 250f, Color.Wheat, "Item Priority (Debug)");
                        foreach (var item in Items.CoreItem.PriorityList().OrderByDescending(a => a.Priority))
                        {
                            for (int i = 0; i < Items.CoreItem.PriorityList().Count(); i++)
                            {
                                Drawing.DrawText(200, 265 + 5 * (i * 3), Color.White, item.DisplayName + " : " + item.Priority);
                            }
                        }

                    }
                }

                if (!Activator.SmiteInGame)
                {
                    return;
                }

                if (Activator.Origin.Item("drawsmitet").GetValue<bool>())
                {
                    var wts = Drawing.WorldToScreen(Activator.Player.Position);

                    if (Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                        Drawing.DrawText(wts[0] - 35, wts[1] + 55, Color.White, "Smite: ON");

                    if (!Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                        Drawing.DrawText(wts[0]- 35, wts[1] + 55, Color.Gray, "Smite: OFF");
                }

                if (Activator.Origin.Item("drawsmite").GetValue<bool>())
                {
                    if (Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                        Render.Circle.DrawCircle(Activator.Player.Position, 500f, Color.White, 2);

                    if (!Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                        Render.Circle.DrawCircle(Activator.Player.Position, 500f, Color.Gray, 2);
                }

                if (!Activator.Player.IsDead && Activator.Origin.Item("drawfill").GetValue<bool>())
                {
                    if (Activator.MapId != (int) MapType.SummonersRift)
                    {
                        return;
                    }
                        
                    const int height = 6;
                    const int width = 150;
                    const int yoffset = 20;
                    const int xoffset = -7;

                    foreach (
                        var minion in
                            MinionManager.GetMinions(Activator.Player.Position, 1200f, MinionTypes.All,
                                MinionTeam.Neutral)
                                .Where(th => Essentials.IsEpicMinion(th) || Essentials.IsLargeMinion(th)))
                    {
                        if (!minion.IsHPBarRendered)
                        {
                            continue;
                        }

                        var barPos = minion.HPBarPosition;

                        var smite = Activator.Player.GetSpell(Activator.Smite).State == SpellState.Ready
                            ? Activator.Player.GetSummonerSpellDamage(minion, Damage.SummonerSpell.Smite)
                            : 0;

                        var damage = smite; // + ddmg;
                        var pctafter = Math.Max(0, minion.Health - damage) / minion.MaxHealth;

                        var yaxis = barPos.Y + yoffset;
                        var xaxisdmg = (float) (barPos.X + xoffset + width * pctafter);
                        var xaxisnow = barPos.X + xoffset + width * minion.Health / minion.MaxHealth;

                        var ana = xaxisnow - xaxisdmg;
                        var pos = barPos.X + xoffset + 12 + (139 * pctafter);

                        for (var i = 0; i < ana; i++)
                        {
                            if (Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                                Drawing.DrawLine((float) pos + i, yaxis, (float) pos + i, yaxis + height, 1,
                                    Color.White);

                            if (!Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                                Drawing.DrawLine((float) pos + i, yaxis, (float) pos + i, yaxis + height, 1,
                                    Color.Gray);
                        }
                    }
                }
            };
        }
    }
}
