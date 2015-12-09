using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using KL = KurisuNidalee.KurisuLib;
using KN = KurisuNidalee.KurisuNidalee;

namespace KurisuNidalee
{
    internal class CastManager
    {
        // Human Q Logic
        internal static void CastJavelin(Obj_AI_Base target, string mode)
        {
            // if not harass mode ignore mana check
            if (!KL.CatForm() && (mode != "ha" || KL.Player.ManaPercent > 65))
            {
                if (!KL.SpellTimer["Javelin"].IsReady() || !KN.Root.Item("ndhq" + mode).GetValue<bool>()) 
                    return;

                if (target.IsValidTarget(KL.Spells["Javelin"].Range))
                {
                    // try prediction on champion
                    if (target.IsChampion())
                    {
                        var qoutput = KL.Spells["Javelin"].GetPrediction(target);
                        if (qoutput.Hitchance == HitChance.Collision && KN.Root.Item("qsmcol").GetValue<bool>())
                        {
                            if (qoutput.CollisionObjects.All(i => i.NetworkId != KL.Player.NetworkId))
                            {
                                var obj = qoutput.CollisionObjects.Cast<Obj_AI_Minion>().ToList();
                                if (obj.Count == 1)
                                {
                                    if (obj.Any(
                                        i => i.Health <= KL.Player.GetSummonerSpellDamage(i, Damage.SummonerSpell.Smite) &&
                                            KL.Player.Distance(i) < 500 && KL.Player.Spellbook.CastSpell(KL.Smite, obj.First())))
                                    {
                                        KL.Spells["Javelin"].Cast(qoutput.CastPosition);
                                        return;
                                    }
                                }
                            }
                        }
                        
                        if (KN.Root.Item("ndhqcheck").GetValue<bool>())
                        {
                            if (qoutput.Hitchance >= (HitChance) KN.Root.Item("ndhqch").GetValue<StringList>().SelectedIndex + 3)
                            {
                                KL.Spells["Javelin"].Cast(qoutput.CastPosition);
                            }
                        }
                    }

                    if (!target.IsChampion() && !target.PassiveRooted()|| !KN.Root.Item("ndhqcheck").GetValue<bool>())
                    {
                        if (KL.Spells["Javelin"].Cast(target) != Spell.CastStates.Collision)
                        {
                            KL.Spells["Javelin"].Cast(target.ServerPosition);
                        }
                    }
                }
            }
        }

        // Human W Logic
        internal static void CastBushwhack(Obj_AI_Base target, string mode)
        {           
            // if not harass mode ignore mana check
            if (!KL.CatForm() && (mode != "ha" || KL.Player.ManaPercent > 65))
            {
                if (!KL.SpellTimer["Bushwhack"].IsReady() || !KN.Root.Item("ndhw" + mode).GetValue<bool>()) 
                    return;

                if (target.IsValidTarget(KL.Spells["Bushwhack"].Range))
                {
                    // try bushwhack prediction
                    if (KN.Root.Item("ndhwforce").GetValue<StringList>().SelectedIndex == 0)
                    {
                        if (target.IsChampion())
                            KL.Spells["Bushwhack"].CastIfHitchanceEquals(target, HitChance.VeryHigh);
                        else
                            KL.Spells["Bushwhack"].Cast(target.ServerPosition);
                    }

                    // try bushwhack behind target
                    if (KN.Root.Item("ndhwforce").GetValue<StringList>().SelectedIndex == 1)
                    {
                        var unitpos = KL.Spells["Bushwhack"].GetPrediction(target).UnitPosition;
                        KL.Spells["Bushwhack"].Cast(unitpos.Extend(KL.Player.ServerPosition, -75f));
                    }
                }
            }
        }


        // Cougar Q Logic
        internal static void CastTakedown(Obj_AI_Base target, string mode)
        {
            if (KL.CatForm())
            {
                if (!KL.SpellTimer["Takedown"].IsReady() || !KN.Root.Item("ndcq" + mode).GetValue<bool>())
                    return;

                // temp logic to prevent takdown cast before swipe
                if (!KL.SpellTimer["Swipe"].IsReady() || KL.NotLearned(KL.Spells["Swipe"]) || !KN.Root.Item("ndce" + mode).GetValue<bool>())
                {
                    if (target.IsValidTarget(KL.Player.AttackRange + KL.Spells["Takedown"].Range))
                    {
                        KL.Spells["Takedown"].CastOnUnit(target);
                    }
                }
            }
        }


        // Cougar W Logic
        internal static void CastPounce(Obj_AI_Base target, string mode)
        {
            // check the actual spell timer and if we have it enabled in our menu
            if (!KL.CatForm() || !KL.SpellTimer["Pounce"].IsReady() || !KN.Root.Item("ndcw" + mode).GetValue<bool>()) 
                return;

            // check if target is hunted in 750 range
            if (!target.IsValidTarget(KL.Spells["ExPounce"].Range))
                return;

            if (target.IsHunted())
            {
                // get hitbox
                var radius = KL.Player.AttackRange + KL.Player.Distance(KL.Player.BBox.Minimum) + 1;

                // force pounce if menu item enabled
                if (target.IsHunted() && KN.Root.Item("ndcwhunt").GetValue<bool>() ||

                    // or of target is greater than my attack range
                    target.Distance(KL.Player.ServerPosition) > radius ||

                    // or is jungling or waveclearing (without farm distance check)
                    mode == "jg" || mode == "wc" && !KN.Root.Item("ndcwdistwc").GetValue<bool>() ||

                    // or combo mode and ignoring distance check
                    !target.IsHunted() && mode == "co" && !KN.Root.Item("ndcwdistco").GetValue<bool>())
                {
                    if (KN.Root.Item("kitejg").GetValue<bool>() && mode == "jg" &&
                        target.Distance(KL.Player.ServerPosition) <= KL.Spells["Pounce"].Range - 50 && 
                        target.Distance(Game.CursorPos) > 375)
                    {
                        KL.Spells["Pounce"].Cast(Game.CursorPos);
                        return;
                    }

                    KL.Spells["Pounce"].Cast(target.ServerPosition);
                }
            }

            // if target is not hunted
            else
            {
                // check if in the original pounce range
                if (target.Distance(KL.Player.ServerPosition) > KL.Spells["Pounce"].Range)
                    return;

                // get hitbox
                var radius = KL.Player.AttackRange + KL.Player.Distance(KL.Player.BBox.Minimum) + 1;

                // check minimum distance before pouncing
                if (target.Distance(KL.Player.ServerPosition) > radius || 

                    // or is jungling or waveclearing (without distance checking)
                    mode == "jg" ||  mode == "wc" && !KN.Root.Item("ndcwdistwc").GetValue<bool>() ||

                    // or combo mode with no distance checking
                    mode == "co" && !KN.Root.Item("ndcwdistco").GetValue<bool>())
                {
                    if (target.IsChampion())
                    {
                        if (KN.Root.Item("ndcwcheck").GetValue<bool>())
                        {
                            var voutout = KL.Spells["Pounce"].GetPrediction(target);
                            if (voutout.Hitchance >= (HitChance) KN.Root.Item("ndcwch").GetValue<StringList>().SelectedIndex + 3)
                            {
                                KL.Spells["Pounce"].Cast(voutout.CastPosition);
                            }
                        }
                        else
                            KL.Spells["Pounce"].Cast(target.ServerPosition);
                    }
                    else 
                    {
                        // check pouncing near enemies
                        if (mode == "wc" && KN.Root.Item("ndcwene").GetValue<bool>() &&
                            target.ServerPosition.CountEnemiesInRange(550) > 0)
                            return;

                        // check pouncing under turret
                        if (mode == "wc" && KN.Root.Item("ndcwtow").GetValue<bool>() &&
                            target.ServerPosition.UnderTurret(true))
                            return;

                        KL.Spells["Pounce"].Cast(target.ServerPosition);
                    }
                }
            }
        }


        // Cougar E Logic
        internal static void CastSwipe(Obj_AI_Base target, string mode)
        {
            if (KL.CatForm() && KL.SpellTimer["Swipe"].IsReady() && KN.Root.Item("ndce" + mode).GetValue<bool>())
            {
                if (target.IsValidTarget(KL.Spells["Swipe"].Range))
                {
                    if (target.IsChampion())
                    {
                        if (KN.Root.Item("ndcecheck").GetValue<bool>())
                        {
                            var voutout = KL.Spells["Swipe"].GetPrediction(target);
                            if (voutout.Hitchance >= (HitChance) KN.Root.Item("ndcech").GetValue<StringList>().SelectedIndex + 3)
                            {
                                KL.Spells["Swipe"].Cast(voutout.CastPosition);
                            }
                        }
                        else
                            KL.Spells["Swipe"].Cast(target.ServerPosition);
                    }
                    else
                    {
                        // try aoe swipe if menu item > 1
                        var minhit = KN.Root.Item("ndcenum").GetValue<Slider>().Value;
                        if (minhit > 1 && mode == "wc")
                            KL.CastSmartSwipe();

                        // or cast normal
                        else
                            KL.Spells["Swipe"].Cast(target.ServerPosition);
                    }
                }
            }

            // check valid target in range
        }


        internal static void SwitchForm(Obj_AI_Base target, string mode)
        {
            if (!target.IsValidTarget(KL.Spells["Javelin"].Range))
                return;

            // catform -> human
            if (KL.CatForm() && KL.Spells["Aspect"].IsReady() && KN.Root.Item("ndcr" + mode).GetValue<bool>())
            {
                // get hitbox
                var radius = KL.Player.AttackRange + KL.Player.Distance(KL.Player.BBox.Minimum) + 1;

                // dont switch if have Q buff and near target
                if (KL.SpellTimer["Takedown"].IsReady() && KL.Player.HasBuff("Takedown") &&
                    target.Distance(KL.Player.ServerPosition) <= KL.Spells["Takedown"].Range + 45f)
                {
                    return;
                }

                // change form if Q is ready and meets hitchance
                if (KL.SpellTimer["Javelin"].IsReady() && target.IsChampion())
                {
                    var poutput = KL.Spells["Javelin"].GetPrediction(target);
                    if (poutput.Hitchance >= HitChance.High)
                    {
                        KL.Spells["Aspect"].Cast();
                    }
                }

                // is jungling
                if (mode == "jg")
                {
                    if (KL.SpellTimer["Bushwhack"].IsReady() && KL.Spells["Bushwhack"].Level > 0 ||
                        KL.SpellTimer["Javelin"].IsReady() && KL.Spells["Javelin"].Level > 0)
                    {
                        if (KL.Spells["Javelin"].Cast(target) != Spell.CastStates.Collision && 
                            KL.SpellTimer["Javelin"].IsReady() || KL.SpellTimer["Bushwhack"].IsReady())
                        {
                            if (!KL.SpellTimer["Swipe"].IsReady() || !KL.SpellTimer["Takedown"].IsReady() ||
                                KL.Player.Distance(target.ServerPosition) > 355)
                            {
                                KL.Spells["Aspect"].Cast();
                            }
                        }
                    }
                }
                else
                {
                    // change to human if out of pounce range and can die
                    if (!KL.SpellTimer["Pounce"].IsReady() && target.Distance(KL.Player.ServerPosition) <= 525)
                    {
                        if (target.Distance(KL.Player.ServerPosition) > radius)
                        {
                            if (KL.Player.GetAutoAttackDamage(target, true) * 3 >= target.Health)
                                KL.Spells["Aspect"].Cast();
                        }
                    }
                }
            }

            // human -> catform
            if (!KL.CatForm() && KL.Spells["Aspect"].IsReady() && KN.Root.Item("ndhr" + mode).GetValue<bool>())
            {
                if (mode == "jg")
                {
                    if (KL.Counter < KN.Root.Item("aareq").GetValue<Slider>().Value &&
                        KN.Root.Item("jgaacount").GetValue<KeyBind>().Active)
                    {
                        return;
                    }
                }

                if (mode == "gap")
                {
                    if (target.IsValidTarget(375))
                    {
                        KL.Spells["Aspect"].Cast();
                        return;
                    }
                }

                if (mode == "wc")
                {
                    if (target.IsValidTarget(375) && target.IsMinion)
                    {
                        KL.Spells["Aspect"].Cast();
                        return;
                    }
                }

                if (target.IsHunted())
                {
                    // force switch no swipe/takedown req
                    if (!KN.Root.Item("ndhrcreq").GetValue<bool>() && mode == "co" ||
                        !KN.Root.Item("ndhrjreq").GetValue<bool>() && mode == "jg")
                    {
                        KL.Spells["Aspect"].Cast();
                        return;
                    }

                    // or check if pounce timer is ready before switch
                    if (KL.Spells["Aspect"].IsReady() && target.IsValidTarget(KL.Spells["ExPounce"].Range))
                    {
                        // dont pounce if swipe or takedown isn't ready
                        if ((KL.SpellTimer["Takedown"].IsReady() || KL.SpellTimer["Swipe"].IsReady()) &&
                            KL.SpellTimer["Pounce"].IsReady(1))
                            KL.Spells["Aspect"].Cast();
                    }
                }
                else
                {
                    // check if in pounce range oops.
                    if (target.Distance(KL.Player.ServerPosition) <= KL.Spells["Pounce"].Range + 100)
                    {
                        if (target.IsValidTarget(KL.Spells["Pounce"].Range + 100))
                        {
                            if (mode != "jg")
                            {
                                // switch to cougar if can kill target
                                if (KL.CatDamage(target) >= target.Health)
                                {
                                    if (mode == "co" && target.IsValidTarget(KL.Spells["Pounce"].Range))
                                        KL.Spells["Aspect"].Cast();
                                }

                                // switch if Q disabled in menu
                                if (!KN.Root.Item("ndhq" + mode).GetValue<bool>() ||

                                    // or Q is not learned
                                    KL.NotLearned(KL.Spells["Javelin"]) ||

                                    // delay the cast .5 seconds
                                    Utils.GameTimeTickCount - (int) (KL.TimeStamp["Javelin"] * 1000) +
                                    ((6 + (6 * KL.Player.PercentCooldownMod)) * 1000) >= 500 &&

                                    // if Q is not ready in 2 seconds
                                    !KL.SpellTimer["Javelin"].IsReady(2))
                                {
                                    KL.Spells["Aspect"].Cast();
                                }
                            }
                            else
                            {
                                if (KL.Spells["Javelin"].Cast(target) == Spell.CastStates.Collision && KN.Root.Item("spcol").GetValue<bool>())
                                {
                                    if (!KL.SpellTimer["Bushwhack"].IsReady() || KL.NotLearned(KL.Spells["Bushwhack"]))
                                    {
                                        if (KL.Spells["Aspect"].IsReady())
                                            KL.Spells["Aspect"].Cast();
                                    }
                                }
                            }
                        }
                    }

                    if (KN.Target.IsValidTarget(KL.Spells["Javelin"].Range) && target.IsChampion())
                    {
                        if (KL.SpellTimer["Javelin"].IsReady())
                        {
                            // check if in pounce range.
                            if (target.Distance(KL.Player.ServerPosition) <= KL.Spells["Pounce"].Range + 25)
                            {
                                // if we dont meet hitchance on Q target pounce nearest target
                                var poutput = KL.Spells["Javelin"].GetPrediction(target);
                                if (poutput.Hitchance >= (HitChance) (KN.Root.Item("ndhqch").GetValue<StringList>().SelectedIndex + 3))
                                {
                                    if (KL.Spells["Aspect"].IsReady())
                                        KL.Spells["Aspect"].Cast();
                                }
                            }
                        }

                        if (KN.Target.IsHunted() && KN.Target.Distance(KL.Player.ServerPosition) >
                            KL.Spells["ExPounce"].Range + 100)
                        {
                            if (target.Distance(KL.Player.ServerPosition) <= KL.Spells["Pounce"].Range + 25)
                            {
                                if (KL.Spells["Aspect"].IsReady())
                                    KL.Spells["Aspect"].Cast();
                            }
                        }

                        if (!KL.SpellTimer["Javelin"].IsReady())
                        {
                            if (target.Distance(KL.Player.ServerPosition) <= KL.Spells["Pounce"].Range + 125)
                            {
                                KL.Spells["Aspect"].Cast();
                            }
                        }
                    }
                }
            }
        }
    }
}
