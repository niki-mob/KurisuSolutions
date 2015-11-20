using System;
using System.Drawing;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using CM = KurisuNidalee.CastManager;
using Color = System.Drawing.Color;
using ES = KurisuNidalee.Essentials;

namespace KurisuNidalee
{
    internal class KurisuNidalee
    {
        internal static Menu Root;
        internal static Obj_AI_Hero Target;
        internal static Orbwalking.Orbwalker Orbwalker;
        internal static Obj_AI_Hero Player = ObjectManager.Player;

        internal KurisuNidalee()
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        internal static void Game_OnGameLoad(EventArgs args)
        {
            if (Player.ChampionName != "Nidalee")
                return;

            Root = new Menu("Kurisu's Nidalee", "nidalee", true);

            var orbm = new Menu(":: Orbwalker", "orbm");
            Orbwalker = new Orbwalking.Orbwalker(orbm);
            orbm.AddItem(new MenuItem("flee", "Flee"))
                .SetValue(new KeyBind('A', KeyBindType.Press));
            Root.AddSubMenu(orbm);

            var ccmenu = new Menu(":: Nidalee Settings", "ccmenu");

            var humenu = new Menu(":: Human Settings", "humenu");

            var ndhq = new Menu("(Q)  Javelin", "ndhq");
            ndhq.AddItem(new MenuItem("ndhqcheck", "Check Hitchance")).SetValue(true);
            ndhq.AddItem(new MenuItem("ndhqch", "-> Min Hitchance"))
                .SetValue(new StringList(new[] { "Low", "Medium", "High", "Very High" }, 2));
            ndhq.AddItem(new MenuItem("qsmcol", "-> Smite Collision")).SetValue(true);
            ndhq.AddItem(new MenuItem("ndhqco", "Enable in Combo")).SetValue(true);
            ndhq.AddItem(new MenuItem("ndhqha", "Enable in Harass")).SetValue(true);
            ndhq.AddItem(new MenuItem("ndhqjg", "Enable in Jungle")).SetValue(true);
            ndhq.AddItem(new MenuItem("ndhqwc", "Enable in WaveClear")).SetValue(false);
            ndhq.AddItem(new MenuItem("ndhqimm", "-> Auto (Q) Immobile")).SetValue(true);
            ndhq.AddItem(new MenuItem("ndhqgap", "-> Auto (Q) Gapclosers")).SetValue(true);
            humenu.AddSubMenu(ndhq);

            var ndhw = new Menu("(W) Bushwack", "ndhw");
            ndhw.AddItem(new MenuItem("ndhwco", "Enable in Combo")).SetValue(true);
            ndhw.AddItem(new MenuItem("ndhwjg", "Enable in Jungle")).SetValue(true);
            ndhw.AddItem(new MenuItem("ndhwwc", "Enable in WaveClear")).SetValue(false);
            ndhw.AddItem(new MenuItem("ndhwforce", "Location")).SetValue(new StringList(new[] { "Prediction", "Behind Target" }));
            ndhw.AddItem(new MenuItem("ndhwimm", "->  Auto (W) Immobile Targets")).SetValue(true);
            humenu.AddSubMenu(ndhw);

            var ndhe = new Menu("(E)  Primal Surge", "ndhe");
            ndhe.AddItem(new MenuItem("ndheon", "Enable Healing")).SetValue(true);
            ndhe.AddItem(new MenuItem("ndhemana", "-> Minumum Mana")).SetValue(new Slider(55, 1));
            ndhe.AddItem(new MenuItem("ndhesw", "Switch Forms")).SetValue(false);

            foreach (var hero in HeroManager.Allies)
            {
                ndhe.AddItem(new MenuItem("x" + hero.ChampionName, "Heal on " + hero.ChampionName)).SetValue(hero.IsMe);
                ndhe.AddItem(new MenuItem("z" + hero.ChampionName, hero.ChampionName + " below Pct% ")).SetValue(new Slider(66, 1, 99));
            }

            humenu.AddSubMenu(ndhe);

            var ndhr = new Menu("(R) Aspect of the Cougar", "ndhr");
            ndhr.AddItem(new MenuItem("ndhrwh", "Switch When")).SetValue(new StringList(new[] { "Auto", "Hunted Only", "Always" }));
            ndhr.AddItem(new MenuItem("ndhrco", "Enable in Combo")).SetValue(true);
            ndhr.AddItem(new MenuItem("ndhrcreq", "-> Require Swipe/Takedown")).SetValue(true);
            ndhr.AddItem(new MenuItem("ndhrha", "Enable in Harass")).SetValue(true);
            ndhr.AddItem(new MenuItem("ndhrjg", "Enable in Jungle")).SetValue(true);
            ndhr.AddItem(new MenuItem("ndhrjreq", "-> Require Swipe/Takedown")).SetValue(true);
            ndhr.AddItem(new MenuItem("ndhrwc", "Enable in WaveClear")).SetValue(false);
            ndhr.AddItem(new MenuItem("ndhrgap", "-> Auto (R) Enemy Gapclosers")).SetValue(true);
            humenu.AddSubMenu(ndhr);

            var comenu = new Menu(":: Cougar Settings", "comenu");

            var ndcq = new Menu("(Q) Takedown", "ndcq");
            ndcq.AddItem(new MenuItem("ndcqco", "Enable in Combo")).SetValue(true);
            ndcq.AddItem(new MenuItem("ndcqha", "Enable in Harass")).SetValue(true);
            ndcq.AddItem(new MenuItem("ndcqjg", "Enable in Jungle")).SetValue(true);
            ndcq.AddItem(new MenuItem("ndcqwc", "Enable in WaveClear")).SetValue(true);
            ndcq.AddItem(new MenuItem("ndcqgap", "-> Auto (Q) Enemy Gapclosers")).SetValue(true);
            comenu.AddSubMenu(ndcq);

            var ndcw = new Menu("(W) Pounce", "ndcw");
            ndcw.AddItem(new MenuItem("ndcwcheck", "Check Hitchance")).SetValue(false);
            ndcw.AddItem(new MenuItem("ndcwch", "-> Min Hitchance"))
                .SetValue(new StringList(new[] { "Low", "Medium", "High", "Very High" }, 2));
            ndcw.AddItem(new MenuItem("ndcwco", "Enable in Combo")).SetValue(true);
            ndcw.AddItem(new MenuItem("ndcwhunt", "-> Ignore Checks if Hunted")).SetValue(false);
            ndcw.AddItem(new MenuItem("ndcwdistco", "-> Pounce Only if > AARange")).SetValue(true);
            ndcw.AddItem(new MenuItem("ndcwjg", "Enable in Jungle")).SetValue(true);
            ndcw.AddItem(new MenuItem("ndcwwc", "Enable in WaveClear")).SetValue(true);
            ndcw.AddItem(new MenuItem("ndcwdistwc", "-> Pounce Only if > AARange")).SetValue(false);
            ndcw.AddItem(new MenuItem("ndcwene", "-> Dont Pounce into Enemies")).SetValue(true);
            ndcw.AddItem(new MenuItem("ndcwtow", "-> Dont Pounce into Turret")).SetValue(true);
            comenu.AddSubMenu(ndcw);

            var ndce = new Menu("(E) Swipe", "ndce");

            ndce.AddItem(new MenuItem("ndcecheck", "Check Hitchance")).SetValue(false);
            ndce.AddItem(new MenuItem("ndcech", "-> Min Hitchance"))
                .SetValue(new StringList(new[] { "Low", "Medium", "High", "Very High" }, 2));
            ndce.AddItem(new MenuItem("ndceco", "Enable in Combo")).SetValue(true);
            ndce.AddItem(new MenuItem("ndceha", "Enable in Harass")).SetValue(true);
            ndce.AddItem(new MenuItem("ndcejg", "Enable in Jungle")).SetValue(true);
            ndce.AddItem(new MenuItem("ndcewc", "Enable in WaveClear")).SetValue(true);
            ndce.AddItem(new MenuItem("ndcenum", "-> Minimum Minions Hit")).SetValue(new Slider(3, 1, 5));
            ndce.AddItem(new MenuItem("ndcegap", "-> Auto (E) Enemy Gapclosers")).SetValue(true);
            comenu.AddSubMenu(ndce);

            var ndcr = new Menu("(R) Aspect of the Cougar", "ndcr");
            ndcr.AddItem(new MenuItem("ndcrwh", "Switch When")).SetValue(new StringList(new[] { "Auto", "Q Ready", "Out of Range" }));
            ndcr.AddItem(new MenuItem("ndcrco", "Enable in Combo")).SetValue(true);
            ndcr.AddItem(new MenuItem("ndcrha", "Enable in Harass")).SetValue(true);
            ndcr.AddItem(new MenuItem("ndcrjg", "Enable in Jungle")).SetValue(true);
            ndcr.AddItem(new MenuItem("ndcrwc", "Enable in WaveClear")).SetValue(false);

            comenu.AddSubMenu(ndcr);


            var dmenu = new Menu(":: Draw Settings", "dmenu");              
            dmenu.AddItem(new MenuItem("dp", "Draw Q Range")).SetValue(true);
            dmenu.AddItem(new MenuItem("dti",  "Draw Timers")).SetValue(false);
            dmenu.AddItem(new MenuItem("dt", "Draw Target")).SetValue(true);
            ccmenu.AddSubMenu(dmenu);

            ccmenu.AddItem(new MenuItem("pstyle", ":: Play Style"))
                .SetValue(new StringList(new[] {"Assassin", "Team Fighter"}, 0));

            ccmenu.AddItem(new MenuItem("jgaacount", ":: Jungle AA Weaving"))
                .SetValue(false).SetTooltip("Require auto attacks before switching to Cougar");
            ccmenu.AddItem(new MenuItem("aareq", "-> Required auto attack Count")).SetValue(new Slider(2, 1, 5));
            ccmenu.AddSubMenu(comenu);
            ccmenu.AddSubMenu(humenu);

            Root.AddSubMenu(ccmenu);

            var sset = new Menu(":: Smite Settings", "sset");
            sset.AddItem(new MenuItem("jgsmite", "Enable Smite")).SetValue(true);
            sset.AddItem(new MenuItem("jgsmitetd", "Takedown + Smite")).SetValue(true);
            sset.AddItem(new MenuItem("jgsmiteep", "-> Smite Epic")).SetValue(true);
            sset.AddItem(new MenuItem("jgsmitebg", "-> Smite Large")).SetValue(true);
            sset.AddItem(new MenuItem("jgsmitesm", "-> Smite Small")).SetValue(false);
            sset.AddItem(new MenuItem("jgsmitehe", "-> Smite On Hero")).SetValue(true);
            Root.AddSubMenu(sset);

            Root.AddToMainMenu();

            Game.OnUpdate += Game_OnUpdate;
            Drawing.OnDraw += Drawing_OnDraw;
            Game.PrintChat("<b><font color=\"#FF33D6\">Kurisu's Nidalee</font></b> - Loaded!");
        }

        static void Drawing_OnDraw(EventArgs args)
        {
            if (Player.IsDead || !Player.IsValid)
            {
                return;
            }

            if (Root.Item("dti").GetValue<bool>())
            {
                var pos = Drawing.WorldToScreen(Player.Position);
                Drawing.DrawText(pos[0] + 100, pos[1] - 135, Color.White, "Q: " + ES.SpellTimer["Javelin"].ToString("F"));
            }

            if (Root.Item("dt").GetValue<bool>() && Target != null)
            {
                if (Root.Item("pstyle").GetValue<StringList>().SelectedIndex == 0)
                {
                    Render.Circle.DrawCircle(Target.Position, Target.BoundingRadius, Color.DeepPink, 6);
                }
            }

            if (Root.Item("dp").GetValue<bool>())
            {
                Render.Circle.DrawCircle(ES.Player.Position, !ES.CatForm()
                    ? ES.Spells["Javelin"].Range : ES.Spells["ExPounce"].Range, Color.FromArgb(155, Color.DeepPink), 4);
            }
        }

        internal static void Game_OnUpdate(EventArgs args)
        {
            Target = TargetSelector.GetTarget(ES.Spells["Javelin"].Range, TargetSelector.DamageType.Magical);

            switch (Orbwalker.ActiveMode)
            {
                case Orbwalking.OrbwalkingMode.Combo:
                    Combo();
                    break;
                case Orbwalking.OrbwalkingMode.LaneClear:
                    Jungle();
                    WaveClear();
                    break;
                case Orbwalking.OrbwalkingMode.Mixed:
                    Harass();
                    break;
            }

            if (Root.Item("flee").GetValue<KeyBind>().Active)
                Flee();

            // auto bushwack on immobile
            if (Root.Item("ndhwimm").GetValue<bool>() && !ES.CatForm() && ES.SpellTimer["Bushwhack"].IsReady())
            {
                foreach (var unit in HeroManager.Enemies.Where(h => h.IsValidTarget(ES.Spells["Bushwhack"].Range)))
                {
                    ES.Spells["Bushwhack"].CastIfHitchanceEquals(unit, HitChance.Immobile);

                    if (ES.Immobile(unit))
                        ES.Spells["Bushwhack"].Cast(unit);
                }
            }

            // auto javelin on immobile
            if (Root.Item("ndhqimm").GetValue<bool>() && !ES.CatForm() && ES.SpellTimer["Javelin"].IsReady())
            {
                foreach (var unit in HeroManager.Enemies.Where(h => h.IsValidTarget(ES.Spells["Javelin"].Range)))
                {
                    ES.Spells["Javelin"].CastIfHitchanceEquals(unit, HitChance.Immobile);

                    if (ES.Immobile(unit))
                        ES.Spells["Javelin"].Cast(unit);
                }
            }

            // auto heal on ally hero
            if (Root.Item("ndheon").GetValue<bool>() && ES.SpellTimer["Primalsurge"].IsReady())
            {
                if (ES.NotLearned(ES.Spells["Primalsurge"]))
                    return;

                if (Player.Spellbook.IsChanneling || Player.IsRecalling())
                    return;

                if (Root.Item("flee").GetValue<KeyBind>().Active && ES.CatForm())
                    return;

                if (Player.Mana/Player.MaxMana*100 < 
                    Root.Item("ndhemana").GetValue<Slider>().Value)
                    return;

                if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.None && ES.CatForm() || !ES.CatForm())
                {
                    foreach (
                        var hero in
                            HeroManager.Allies.Where(
                                h => Root.Item("x" + h.ChampionName).GetValue<bool>() &&
                                     h.IsValidTarget(ES.Spells["Primalsurge"].Range, false) &&
                                     h.Health / h.MaxHealth * 100 <
                                     Root.Item("z" + h.ChampionName).GetValue<Slider>().Value))
                    {
                        if (ES.CatForm() == false)
                            ES.Spells["Primalsurge"].CastOnUnit(hero);

                        if (ES.CatForm() && Root.Item("ndhesw").GetValue<bool>() && ES.Spells["Aspect"].IsReady())
                            ES.Spells["Aspect"].Cast();
                    }
                }
            }
        }

        internal static void Combo()
        {
            var assassin = Root.Item("pstyle").GetValue<StringList>().SelectedIndex == 0;

            CM.CastJavelin(assassin ? Target : TargetSelector.GetTarget(ES.Spells["Javelin"].Range, TargetSelector.DamageType.Magical), "co");
            CM.CastBushwack(assassin ? Target : TargetSelector.GetTarget(ES.Spells["Bushwhack"].Range, TargetSelector.DamageType.Magical), "co");
            CM.CastTakedown(assassin ? Target : TargetSelector.GetTarget(ES.Spells["Takedown"].Range, TargetSelector.DamageType.Magical), "co");
            CM.CastPounce(assassin ? Target : TargetSelector.GetTarget(ES.Spells["ExPounce"].Range, TargetSelector.DamageType.Magical), "co");
            CM.CastSwipe(assassin ? Target : TargetSelector.GetTarget(ES.Spells["Swipe"].Range, TargetSelector.DamageType.Magical), "co");
            CM.SwitchForm(assassin ? Target : TargetSelector.GetTarget(ES.Spells["Javelin"].Range, TargetSelector.DamageType.Magical), "co");
        }

        internal static void Harass()
        {
            CM.CastJavelin(TargetSelector.GetTarget(ES.Spells["Javelin"].Range, TargetSelector.DamageType.Magical), "ha");
            CM.CastTakedown(TargetSelector.GetTarget(ES.Spells["Takedown"].Range, TargetSelector.DamageType.Magical), "ha");
            CM.CastSwipe(TargetSelector.GetTarget(ES.Spells["Swipe"].Range, TargetSelector.DamageType.Magical), "ha");
            CM.SwitchForm(TargetSelector.GetTarget(ES.Spells["Javelin"].Range, TargetSelector.DamageType.Magical), "ha");
        }

        internal static void Jungle()
        {
            foreach (
                var minion in
                    ObjectManager.Get<Obj_AI_Minion>()
                        .Where(x => ES.MinionList.Any(y => x.Name.StartsWith(y) || x.IsHunted())))
            {
                if (minion.IsValidTarget(ES.Spells["ExPounce"].Range) &&
                   (!minion.Name.Contains("Mini") || minion.IsHunted()))
                {
                    CM.CastJavelin(minion, "jg");
                    CM.CastPounce(minion, "jg");
                    CM.CastBushwack(minion, "jg");
                    CM.CastTakedown(minion, "jg");
                    CM.CastSwipe(minion, "jg");
                    CM.SwitchForm(minion, "jg");

                    if (!minion.IsHunted() && !minion.Name.Contains("Mini"))
                    {
                        return;
                    }
                }
            }

            foreach (var minion in ObjectManager.Get<Obj_AI_Minion>().Where(x => !x.IsMinion))
            {
                if (minion.IsValidTarget(ES.Spells["ExPounce"].Range))
                {
                    CM.CastJavelin(minion, "jg");
                    CM.CastBushwack(minion, "jg");
                    CM.CastTakedown(minion, "jg");
                    CM.CastPounce(minion, "jg");
                    CM.CastSwipe(minion, "jg");
                    CM.SwitchForm(minion, "jg");
                }
            }
        }

        internal static void WaveClear()
        {
            foreach (var minion in ES.MinionCache.Values.Where(x => x.IsMinion && x.IsValidTarget(ES.Spells["ExPounce"].Range)))
            {
                CM.CastJavelin(minion, "wc");
                CM.CastBushwack(minion, "wc");
                CM.CastTakedown(minion, "wc");
                CM.CastPounce(minion, "wc");
                CM.CastSwipe(minion, "wc");
                CM.SwitchForm(minion, "wc");
            }
        }


        internal static void Flee()
        {
            if (!ES.CatForm() && ES.Spells["Aspect"].IsReady())
            {
                if (ES.SpellTimer["Pounce"].IsReady())
                    ES.Spells["Aspect"].Cast();
            }

            var wallCheck = ES.GetFirstWallPoint(ES.Player.Position, Game.CursorPos);

            if (wallCheck != null)
                wallCheck = ES.GetFirstWallPoint((Vector3) wallCheck, Game.CursorPos, 5);

            var movePosition = wallCheck != null ? (Vector3) wallCheck : Game.CursorPos;

            var tempGrid = NavMesh.WorldToGrid(movePosition.X, movePosition.Y);
            var fleeTargetPosition = NavMesh.GridToWorld((short) tempGrid.X, (short)tempGrid.Y);

            Obj_AI_Base target = null;

            var wallJumpPossible = false;

            if (ES.CatForm() && ES.SpellTimer["Pounce"].IsReady() && wallCheck != null)
            {
                var wallPosition = movePosition;

                var direction = (Game.CursorPos.To2D() - wallPosition.To2D()).Normalized();
                float maxAngle = 80f;
                float step = maxAngle / 20;
                float currentAngle = 0;
                float currentStep = 0;
                bool jumpTriggered = false;

                while (true)
                {
                    if (currentStep > maxAngle && currentAngle < 0)
                        break;

                    if ((currentAngle == 0 || currentAngle < 0) && currentStep != 0)
                    {
                        currentAngle = (currentStep) * (float)Math.PI / 180;
                        currentStep += step;
                    }

                    else if (currentAngle > 0)
                        currentAngle = -currentAngle;

                    Vector3 checkPoint;

                    if (currentStep == 0)
                    {
                        currentStep = step;
                        checkPoint = wallPosition + ES.Spells["Pounce"].Range * direction.To3D();
                    }

                    else
                        checkPoint = wallPosition + ES.Spells["Pounce"].Range * direction.Rotated(currentAngle).To3D();

                    if (checkPoint.IsWall()) 
                        continue;

                    wallCheck = ES.GetFirstWallPoint(checkPoint, wallPosition);

                    if (wallCheck == null) 
                        continue;

                    var wallPositionOpposite =  (Vector3) ES.GetFirstWallPoint((Vector3)wallCheck, wallPosition, 5);

                    if (ES.Player.GetPath(wallPositionOpposite).ToList().To2D().PathLength() -
                        ES.Player.Distance(wallPositionOpposite) > 200)
                    {
                        if (ES.Player.Distance(wallPositionOpposite) < ES.Spells["Pounce"].Range - ES.Player.BoundingRadius / 2)
                        {
                            ES.Spells["Pounce"].Cast(wallPositionOpposite);
                            jumpTriggered = true;
                            break;
                        }

                        else
                            wallJumpPossible = true;
                    }

                    else
                    {
                        Render.Circle.DrawCircle(Game.CursorPos, 35, Color.Red, 2);
                    }
                }

                if (!jumpTriggered)
                    Orbwalking.Orbwalk(target, Game.CursorPos, 90f, 0f, false, false);
            }

            else
            {
                Orbwalking.Orbwalk(target, Game.CursorPos, 90f, 0f, false, false);
                if (ES.CatForm() && ES.SpellTimer["Pounce"].IsReady())
                    ES.Spells["Pounce"].Cast(Game.CursorPos);
            }
        }
    }
}
