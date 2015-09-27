using System;
using Activator.Base;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Evaders
{
    class zedult : CoreSpell
    {
        internal override string Name
        {
            get { return "ZedR"; }
        }

        internal override string DisplayName
        {
            get { return "Death Mark | R"; }
        }

        internal override float Range
        {
            get { return 625f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.Zhonyas }; }
        }

        internal void CastR(Obj_AI_Base unit)
        {
            if (Player.GetSpell(SpellSlot.R).Name == "ZedR")
                CastOnBestTarget((Obj_AI_Hero) unit);

            if (Player.GetSpell(SpellSlot.R).Name != "ZedR")
                UseSpell();
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            if (Player.GetSpell(SpellSlot.R).Name != "ZedR" && 
                !Menu.Item("useswap2").GetValue<bool>())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.NetworkId == Player.NetworkId)
                { 
                    if (!Parent.Item(Parent.Name + "useon" + hero.Player.NetworkId).GetValue<bool>())
                        continue;

                    if (hero.Attacker == null)
                        continue;

                    if (hero.Attacker.Distance(hero.Player.ServerPosition) > Range)
                        continue;

                    if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger))
                            CastR(hero.Attacker);

                    if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                            CastR(hero.Attacker);
                }
            }
        }
    }
}
