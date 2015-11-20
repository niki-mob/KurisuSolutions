using System;
using LeagueSharp;
using LeagueSharp.Common;

using ES = KurisuNidalee.Essentials;
using KN = KurisuNidalee.KurisuNidalee;

namespace KurisuNidalee
{
    internal class Combat
    {
        // Human Q Logic
        internal static void CastJavelin(Obj_AI_Base target, string mode)
        {
            // if not harass mode ignore mana check
            if (!ES.CatForm() && (mode != "ha" || ES.Player.ManaPercent > 65))
            {
                if (!ES.SpellTimer["Javelin"].IsReady() || !KN.Root.Item("ndhq" + mode).GetValue<bool>()) 
                    return;

                if (target.IsValidTarget(ES.Spells["Javelin"].Range))
                {
                    // try prediction on champion
                    if (target.IsChampion() && KN.Root.Item("ndhqcheck").GetValue<bool>())
                        ES.Spells["Javelin"].CastIfHitchanceEquals(target, ES.MyHitChance("hq"));

                    if (!target.IsChampion())
                        ES.Spells["Javelin"].Cast(target);
                }
            }
        }

        // Human W Logic
        internal static void CastBushwack(Obj_AI_Base target, string mode)
        {           
            // if not harass mode ignore mana check
            if (!ES.CatForm() && (mode != "ha" || ES.Player.ManaPercent > 65))
            {
                if (!ES.SpellTimer["Bushwhack"].IsReady() || !KN.Root.Item("ndhw" + mode).GetValue<bool>()) 
                    return;

                if (target.IsValidTarget(ES.Spells["Bushwhack"].Range))
                {
                    // try bushwack prediction
                    if (KN.Root.Item("ndhwforce").GetValue<StringList>().SelectedIndex == 0)
                    {
                        if (target.IsChampion())
                            ES.Spells["Bushwhack"].CastIfHitchanceEquals(target, HitChance.VeryHigh);
                        else
                            ES.Spells["Bushwhack"].Cast(target.ServerPosition);
                    }

                    // try bushwack behind target
                    if (KN.Root.Item("ndhwforce").GetValue<StringList>().SelectedIndex == 1)
                    {
                        var unitpos = ES.Spells["Bushwhack"].GetPrediction(target).UnitPosition;
                        ES.Spells["Bushwhack"].Cast(unitpos.Extend(ES.Player.ServerPosition, -75f));
                    }
                }
            }
        }


        // Cougar Q Logic
        internal static void CastTakedown(Obj_AI_Base target, string mode)
        {
            if (ES.CatForm())
            {
                if (!ES.SpellTimer["Takedown"].IsReady() || !KN.Root.Item("ndcq" + mode).GetValue<bool>())
                    return;

                // temp logic to prevent takdown cast before swipe
                if (!ES.SpellTimer["Swipe"].IsReady() || ES.NotLearned(ES.Spells["Swipe"]) || !KN.Root.Item("ndce" + mode).GetValue<bool>())
                {
                    if (target.IsValidTarget(ES.Player.AttackRange + ES.Spells["Takedown"].Range))
                    {
                        ES.Spells["Takedown"].CastOnUnit(target);
                    }
                }
            }
        }


        // Cougar W Logic
        internal static void CastPounce(Obj_AI_Base target, string mode)
        {
            if (!ES.CatForm())
                return;

            // check the actual spell timer and if we have it enabled in our menu
            if (!ES.SpellTimer["Pounce"].IsReady() || !KN.Root.Item("ndcw" + mode).GetValue<bool>()) 
                return;

            // check if target is hunted in 750 range
            if (!target.IsValidTarget(ES.Spells["ExPounce"].Range))
                return;

            if (target.IsHunted())
            {
                var radius = ES.Player.AttackRange + ES.Player.Distance(ES.Player.BBox.Minimum) + 1;

                // force pounce if menu item enabled
                if (target.IsHunted() && KN.Root.Item("ndcwhunt").GetValue<bool>() ||

                    // or of target is greater than my attack range
                    target.Distance(ES.Player.ServerPosition) > radius ||

                    // or is jungling or waveclearing (without farm distance check)
                    mode == "jg" || mode == "wc" && !KN.Root.Item("ndcwdistwc").GetValue<bool>() ||

                    // or combo mode and ignoring distance check
                    !target.IsHunted() && mode == "co" && !KN.Root.Item("ndcwdistco").GetValue<bool>())
                {
                    // allow kiting between pounce if desired
                    if (mode == "jg" && target.Distance(ES.Player.ServerPosition) < 250)
                        ES.Spells["Pounce"].Cast(!KN.Root.Item("jgsticky").GetValue<bool>()
                            ? Game.CursorPos : target.ServerPosition);
                    else
                        ES.Spells["Pounce"].Cast(target.ServerPosition);
                }
            }

            // if target is not hunted
            else
            {
                if (target.Distance(ES.Player.ServerPosition) > ES.Spells["Pounce"].Range)
                    return;

                var radius = ES.Player.AttackRange + ES.Player.Distance(ES.Player.BBox.Minimum) + 1;

                // check minimum distance before pouncing
                if (target.Distance(ES.Player.ServerPosition) > radius || 

                    // or is jungling or waveclearing (without distance checking)
                    mode == "jg" ||  mode == "wc" && !KN.Root.Item("ndcwdistwc").GetValue<bool>() ||

                    // or combo mode with no distance checking
                    mode == "co" && !KN.Root.Item("ndcwdistco").GetValue<bool>())
                {
                    if (target.IsChampion())
                    {
                        if (KN.Root.Item("ndcwcheck").GetValue<bool>())
                        {
                            var voutout = ES.Spells["Pounce"].GetPrediction(target);
                            if (voutout.Hitchance >= (HitChance) KN.Root.Item("ndcwch").GetValue<StringList>().SelectedIndex + 2)
                            {
                                ES.Spells["Pounce"].Cast(voutout.CastPosition);
                            }
                        }
                        else
                            ES.Spells["Pounce"].Cast(target.ServerPosition);
                    }

                    else 
                    {
                        // check pouncing near enemies
                        if (mode == "wc" && KN.Root.Item("ndcwhunt").GetValue<bool>() &&
                            target.ServerPosition.CountEnemiesInRange(850) > 0)
                            return;

                        // check pouncing under turret
                        if (mode == "wc" && KN.Root.Item("ndcwtow").GetValue<bool>() &&
                            target.ServerPosition.UnderTurret(true))
                            return;

                        // allow kiting between pounce if desired
                        if (mode == "jg" && target.Distance(ES.Player.ServerPosition) < 250)
                            ES.Spells["Pounce"].Cast(!KN.Root.Item("jgsticky").GetValue<bool>()
                                ? Game.CursorPos : target.ServerPosition);
                        else
                            ES.Spells["Pounce"].Cast(target.ServerPosition);
                    }
                }
            }
        }


        // Cougar E Logic
        internal static void CastSwipe(Obj_AI_Base target, string mode)
        {
            if (!ES.CatForm()) 
                return;

            if (!ES.SpellTimer["Swipe"].IsReady() || !KN.Root.Item("ndce" + mode).GetValue<bool>()) 
                return;

            // check valid target in range
            if (target.IsValidTarget(ES.Spells["Swipe"].Range))
            {
                if (target.IsChampion())
                {
                    if (KN.Root.Item("ndcecheck").GetValue<bool>())
                    {
                        var voutout = ES.Spells["Swipe"].GetPrediction(target);
                        if (voutout.Hitchance >= (HitChance) KN.Root.Item("ndcech").GetValue<StringList>().SelectedIndex + 2)
                        {
                            ES.Spells["Swipe"].Cast(voutout.CastPosition);
                        }
                    }
                    else
                        ES.Spells["Swipe"].Cast(target.ServerPosition);
                }

                else
                {
                    // try aoe swipe if menu item > 1
                    var minhit = KN.Root.Item("ndcenum").GetValue<Slider>().Value;
                    if (minhit > 1 && mode == "wc")
                        ES.CastSmartSwipe();

                    // or cast normal
                    else
                        ES.Spells["Swipe"].Cast(target.ServerPosition);
                }
            }
        }


        internal static void SwitchForm(Obj_AI_Base target, string mode)
        {
            if (!target.IsValidTarget(ES.Spells["Javelin"].Range))
                return;

            // catform -> human
            if (ES.CatForm() && ES.Spells["Aspect"].IsReady() && KN.Root.Item("ndcr" + mode).GetValue<bool>())
            {
                var radius = ES.Player.AttackRange + ES.Player.Distance(ES.Player.BBox.Minimum) + 1;

                if (ES.SpellTimer["Takedown"].IsReady() &&
                    target.Distance(ES.Player.ServerPosition) <= ES.Spells["Takedown"].Range + 75f)
                {
                    return;
                }

                // change form if Q is ready and meets hitchance
                if (ES.SpellTimer["Javelin"].IsReady())
                {
                    if (target.IsChampion())
                    {
                        var poutput = ES.Spells["Javelin"].GetPrediction(target);
                        if (poutput.Hitchance >= HitChance.High)
                        {
                            ES.Spells["Aspect"].Cast();
                        }
                    }
                }

                // is jungling
                if (mode == "jg")
                {
                    if (Game.CursorPos.Distance(ES.Player.ServerPosition) >= 375)
                    {
                        if (!KN.Root.Item("jgsticky").GetValue<bool>())
                            ES.Spells["Aspect"].Cast();
                    }

                    if (ES.SpellTimer["Bushwhack"].IsReady() || ES.SpellTimer["Javelin"].IsReady())
                    {
                        if (ES.Spells["Aspect"].Cast(target) == Spell.CastStates.Collision)
                        {
                            if (!ES.SpellTimer["Swipe"].IsReady() && !ES.SpellTimer["Takedown"].IsReady() &&
                                !ES.SpellTimer["Pounce"].IsReady(2))
                                 ES.Spells["Aspect"].Cast();
                        }
                    }
                }

                else
                {
                    // change to human if out of pounce range and can die
                    if (!ES.SpellTimer["Pounce"].IsReady() && target.Distance(ES.Player.ServerPosition) <= 525)
                    {
                        if (target.Distance(ES.Player.ServerPosition) > radius)
                        {
                            if (ES.Player.GetAutoAttackDamage(target, true) * 3 >= target.Health)
                                ES.Spells["Aspect"].Cast();
                        }
                    }
                }
            }

            // human -> catform
            if (ES.CatForm() || !ES.Spells["Aspect"].IsReady() || !KN.Root.Item("ndhr" + mode).GetValue<bool>()) 
                return;

            if (mode == "jg" && ES.Counter < 2 && KN.Root.Item("jgaacount").GetValue<bool>())
                return;

            if (mode == "gap")
            {
                if (target.IsValidTarget(375))
                {
                    ES.Spells["Aspect"].Cast();
                    return;
                }
            }

            // pounce only hunted
            if (KN.Root.Item("ndhrwh").GetValue<StringList>().SelectedIndex == 1)
            {
                if (target.IsValidTarget(ES.Spells["ExPounce"].Range) && target.IsHunted())
                    ES.Spells["Aspect"].Cast();
            }

            // pounce always any condition
            if (KN.Root.Item("ndhrwh").GetValue<StringList>().SelectedIndex == 2)
            {
                if (mode == "wc")
                {
                    if (target.IsValidTarget(375) && target.IsMinion)
                    {
                        ES.Spells["Aspect"].Cast();
                        return;
                    }
                }

                if (target.IsValidTarget(ES.Spells["ExPounce"].Range) && target.IsHunted())
                    ES.Spells["Aspect"].Cast();

                if (target.IsValidTarget(ES.Spells["Pounce"].Range) && !target.IsHunted())
                    ES.Spells["Aspect"].Cast();
            }

            // pounce with my recommended condition
            if (KN.Root.Item("ndhrwh").GetValue<StringList>().SelectedIndex != 0) 
                return;

            if (mode == "wc")
            {
                if (target.IsValidTarget(375) && target.IsMinion)
                {
                    ES.Spells["Aspect"].Cast();
                    return;
                }
            }

            if (target.IsHunted())
            {
                // force switch no swipe/takedown req
                if (!KN.Root.Item("ndhrcreq").GetValue<bool>() && mode == "co" ||
                    !KN.Root.Item("ndhrjreq").GetValue<bool>() && mode == "jg")
                {
                    ES.Spells["Aspect"].Cast();
                    return;
                }

                // or check if pounce timer is ready before switch
                if (ES.SpellTimer["Pounce"].IsReady() && target.IsValidTarget(ES.Spells["ExPounce"].Range))
                {
                    // dont pounce if swipe or takedown isn't ready
                    if (ES.SpellTimer["Takedown"].IsReady() || ES.SpellTimer["Swipe"].IsReady())
                        ES.Spells["Aspect"].Cast();
                }
            }

            else
            {
                // check if in pounce range oops.
                if (target.Distance(ES.Player.ServerPosition) <= ES.Spells["ExPounce"].Range)
                {
                    if (mode == "jg" && target.IsValidTarget(ES.Spells["Pounce"].Range + 100))
                    {
                        // switch to cougar if javelin not ready soon or Q collision
                        if (!ES.SpellTimer["Javelin"].IsReady(2) || ES.Spells["Aspect"].Cast(target) == Spell.CastStates.Collision)
                            ES.Spells["Aspect"].Cast();
                    }

                    // switch to cougar if can kill target
                    if (ES.CatDamage(target) >= target.Health)
                    {
                        if (mode == "co" && target.IsValidTarget(ES.Spells["Pounce"].Range))
                            ES.Spells["Aspect"].Cast();
                    }

                    // switch if Q disabled in menu
                    if (!KN.Root.Item("ndhq" + mode).GetValue<bool>() ||

                        // or Q is not learned
                        ES.NotLearned(ES.Spells["Javelin"]) ||

                        // delay the cast .5 seconds
                        Utils.GameTimeTickCount - (int) (ES.TimeStamp["Javelin"] * 1000) +
                        ((6 + (6 * ES.Player.PercentCooldownMod)) * 1000) >= 500 &&

                        // if Q is not ready in 2 seconds
                        !ES.SpellTimer["Javelin"].IsReady(2))
                    {
                        ES.Spells["Aspect"].Cast();
                    }
                }

                // define our q target
                var qtarget = TargetSelector.GetTarget(ES.Spells["Javelin"].Range,
                              TargetSelector.DamageType.Magical);

                if (qtarget.IsValidTarget(ES.Spells["Javelin"].Range) && target.IsChampion())
                {
                    if (ES.SpellTimer["Javelin"].IsReady())
                    {
 
                        // check if in pounce range.
                        if (target.Distance(ES.Player.ServerPosition) <= ES.Spells["Pounce"].Range + 25)
                        {
                            // if we dont meet hitchance on Q target pounce nearest target
                            var poutput = ES.Spells["Javelin"].GetPrediction(target);
                            if (poutput.Hitchance >= (HitChance)(KN.Root.Item("ndhqch").GetValue<StringList>().SelectedIndex + 3))
                            {
                                ES.Spells["Aspect"].Cast();
                            }
                        }
                    }

                    if (qtarget.IsHunted() && qtarget.Distance(ES.Player.ServerPosition) > ES.Spells["ExPounce"].Range + 100)
                    {
                        if (target.Distance(ES.Player.ServerPosition) <= ES.Spells["Pounce"].Range + 25)
                        {
                            ES.Spells["Aspect"].Cast();
                        }
                    }

                    if (!ES.SpellTimer["Javelin"].IsReady())
                    {
                        if (target.Distance(ES.Player.ServerPosition) <= ES.Spells["Pounce"].Range + 125)
                        {
                            ES.Spells["Aspect"].Cast();
                        }
                    }
                }
            }
        }
    }
}
