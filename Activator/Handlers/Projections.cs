using System;
using System.Linq;
using Activator.Base;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Handlers
{
    public class Projections
    {
        public static void Init()
        {
            GameObject.OnCreate += Missile_OnCreate;
            Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnHeroCast;
        }

        internal static int LastCastedTimeStamp;
        static void Missile_OnCreate(GameObject sender, EventArgs args)
        {
            #region FoW / Missile
            var missile = sender as MissileClient;
            if (missile == null || !missile.IsValid)
                return;

            var caster = missile.SpellCaster as Obj_AI_Hero;
            if (caster == null || !caster.IsValid)
                return;

            if (caster.Team == Activator.Player.Team)
                return;

            var startPos = missile.StartPosition.To2D();
            var endPos = missile.EndPosition.To2D();

            var data = Data.Spelldata.GetByMissileName(missile.SData.Name.ToLower());
            if (data == null)
                return;

            var direction = (endPos - startPos).Normalized();
            if (startPos.Distance(endPos) > data.CastRange)
                endPos = startPos + direction * data.CastRange;

            foreach (var hero in Activator.Allies())
            {
                // reset if needed
                Essentials.ResetIncomeDamage(hero.Player);

                var distance = (1000 * (startPos.Distance(hero.Player.ServerPosition) / data.MissileSpeed));
                var endtime = -100 + Game.Ping / 2 + distance;

                // setup projection
                var proj = hero.Player.ServerPosition.To2D().ProjectOn(startPos, endPos);
                var projdist = hero.Player.ServerPosition.To2D().Distance(proj.SegmentPoint);

                // get the evade time 
                var evadetime = (int)(1000 * (missile.SData.LineWidth - projdist + hero.Player.BoundingRadius) /
                                      hero.Player.MoveSpeed);

                // check if hero on segment
                if (missile.SData.LineWidth + hero.Player.BoundingRadius + 35 <= projdist)
                    continue;

                if (data.Global || Activator.Origin.Item("evade").GetValue<bool>())
                {
                    // ignore if can evade
                    if (hero.Player.NetworkId == Activator.Player.NetworkId)
                    {
                        if (hero.Player.CanMove && evadetime < endtime)
                        {
                            // check next player
                            continue;
                        }
                    }
                }

                if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                    continue;

                hero.Attacker = caster;
                hero.HitTypes.Add(HitType.Spell);
                hero.IncomeDamage += 1;

                if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                    hero.HitTypes.Add(HitType.Danger);
                if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                    hero.HitTypes.Add(HitType.CrowdControl);
                if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                    hero.HitTypes.Add(HitType.Ultimate);
                if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                    hero.HitTypes.Add(HitType.ForceExhaust);

                Utility.DelayAction.Add(250, () =>
                {
                    if (hero.IncomeDamage > 0)
                        hero.IncomeDamage -= 1;

                    hero.HitTypes.Remove(HitType.Spell);

                    if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.Danger);
                    if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.CrowdControl);
                    if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.Ultimate);
                    if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.ForceExhaust);
                });
            }

            #endregion
        }

        static void Obj_AI_Base_OnHeroCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (Essentials.IsEpicMinion(sender) || sender.Name.StartsWith("Sru_Crab"))
                return;

            #region Hero

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Hero)
            {
                LastCastedTimeStamp = Utils.GameTimeTickCount;

                var attacker = sender as Obj_AI_Hero;
                if (attacker == null || attacker.IsAlly || !attacker.IsValid<Obj_AI_Hero>())
                    return;

                foreach (var hero in Activator.Allies())
                {
                    Essentials.ResetIncomeDamage(hero.Player);

                    #region auto attack

                    if (args.SData.IsAutoAttack())
                    {
                        if (args.Target.NetworkId == hero.Player.NetworkId)
                        {
                            float dmg = 0;

                            if (attacker != null)
                            {
                                dmg = (int) Math.Abs(attacker.GetAutoAttackDamage(hero.Player, true));

                                if (sender.HasBuff("sheen"))
                                    dmg += (int) Math.Abs(sender.GetAutoAttackDamage(hero.Player, true) +
                                                        attacker.GetCustomDamage("sheen", hero.Player));

                                if (sender.HasBuff("lichbane"))
                                    dmg += (int) Math.Abs(sender.GetAutoAttackDamage(hero.Player, true) +
                                                        attacker.GetCustomDamage("lichbane", hero.Player));

                                if (sender.HasBuff("itemstatikshankcharge"))
                                    dmg += dmg; // double it yolo (lazy)
                            }

                            if (args.SData.Name.ToLower().Contains("critattack"))
                                dmg = dmg * 2;
       
                            var delay = attacker.AttackCastDelay * 1000;
                            var distance = (int)(1000 * (attacker.ServerPosition.Distance(hero.Player.ServerPosition) / args.SData.MissileSpeed));
                            var endtime = delay - 100 + Game.Ping / 2f + distance - (Utils.GameTimeTickCount - LastCastedTimeStamp);

                            Utility.DelayAction.Add((int)(endtime - (endtime * 0.7)), () =>
                            {
                                hero.Attacker = attacker;
                                hero.HitTypes.Add(HitType.AutoAttack);
                                hero.IncomeDamage += dmg;

                                Utility.DelayAction.Add((int) endtime + 150, delegate
                                {
                                    hero.Attacker = null;
                                    hero.IncomeDamage -= dmg;
                                    hero.HitTypes.Remove(HitType.AutoAttack);
                                });
                            });
                        }
                    }

                    #endregion

                    var data = Data.Spelldata.SomeSpells.Find(x => x.SDataName == args.SData.Name.ToLower());
                    if (data == null)
                        return;

                    #region self/selfaoe

                    if (args.SData.TargettingType == SpellDataTargetType.Self ||
                        args.SData.TargettingType == SpellDataTargetType.SelfAoe)
                    {
                        var fromObj = ObjectManager.Get<GameObject>().FirstOrDefault(
                            x =>
                                data.FromObject != null && !x.IsAlly && data.FromObject.Any(y => x.Name.Contains(y)));

                        var correctpos = fromObj != null ? fromObj.Position : attacker.ServerPosition;
                        if (hero.Player.Distance(correctpos) > data.CastRange)
                            continue;

                        if (data.SDataName == "kalistaexpungewrapper" && !hero.Player.HasBuff("kalistaexpungemarker"))
                            continue;

                        var evadetime = 1000 * (data.CastRange - hero.Player.Distance(correctpos) +
                                                hero.Player.BoundingRadius) / hero.Player.MoveSpeed;

                        if (Activator.Origin.Item("evade").GetValue<bool>())
                        {
                            // ignore if can evade
                            if (hero.Player.NetworkId == Activator.Player.NetworkId)
                            {
                                if (hero.Player.CanMove && evadetime < data.Delay)
                                {
                                    // check next player
                                    continue;
                                }
                            }
                        }

                        if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                            continue;

                        var dmg = (int)Math.Abs(attacker.GetSpellDamage(hero.Player, args.SData.Name));

                        // delay the spell a bit before missile endtime
                        Utility.DelayAction.Add((int)(data.Delay - (data.Delay * 0.7)), () =>
                        {
                            hero.Attacker = attacker;
                            hero.HitTypes.Add(HitType.Spell);
                            hero.IncomeDamage += dmg;

                            if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                hero.HitTypes.Add(HitType.Danger);
                            if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                hero.HitTypes.Add(HitType.CrowdControl);
                            if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                hero.HitTypes.Add(HitType.Ultimate);
                            if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                hero.HitTypes.Add(HitType.ForceExhaust);

                            // lazy safe reset
                            Utility.DelayAction.Add((int) data.Delay + 250, () =>
                            {
                                hero.Attacker = null;
                                hero.IncomeDamage -= dmg;
                                hero.HitTypes.Remove(HitType.Spell);

                                if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.Danger);
                                if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.CrowdControl);
                                if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.Ultimate);
                                if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.ForceExhaust);
                            });
                        });
                    }

                    #endregion

                    #region skillshot

                    if (args.SData.TargettingType == SpellDataTargetType.Cone || 
                        args.SData.TargettingType.ToString().Contains("Location") ||
                        args.SData.TargettingType == (SpellDataTargetType) 10 && data.SDataName == "azirq")
                    {
                        var fromObj =
                            ObjectManager.Get<GameObject>()
                                .FirstOrDefault(
                                    x =>
                                        !x.IsAlly && data.FromObject != null &&
                                        data.FromObject.Any(y => x.Name.Contains(y)));

                        var islineskillshot = args.SData.TargettingType == SpellDataTargetType.Cone ||
                                              args.SData.LineWidth > 0;

                        var startpos = fromObj != null ? fromObj.Position : attacker.ServerPosition;

                        var correctwidth = 0f;

                        if (args.SData.CastRadius > 0) 
                            correctwidth = args.SData.CastRadius;

                        if (args.SData.CastRadius < 1 && args.SData.CastRadiusSecondary > 0)
                            correctwidth = args.SData.CastRadiusSecondary;

                        if (args.SData.CastRadiusSecondary < 1 && args.SData.CastRangeDisplayOverride > 0)
                            correctwidth = args.SData.CastRangeDisplayOverride;

                        if (islineskillshot && args.SData.TargettingType != SpellDataTargetType.Cone)
                            correctwidth = args.SData.LineWidth;

                        if (data.SDataName == "azirq")
                        {
                            correctwidth = 275f;
                            islineskillshot = true;
                        }

                        if (hero.Player.Distance(startpos) > data.CastRange)
                            continue;

                        var distance = (int)(1000 * (startpos.Distance(hero.Player.ServerPosition) / data.MissileSpeed));
                        var endtime = data.Delay - 100 + Game.Ping / 2f + distance - (Utils.GameTimeTickCount - LastCastedTimeStamp);

                        var iscone = args.SData.TargettingType == SpellDataTargetType.Cone;
                        var direction = (args.End.To2D() - startpos.To2D()).Normalized();
                        var endpos = startpos.To2D() + direction * startpos.To2D().Distance(args.End.To2D());

                        if (startpos.To2D().Distance(endpos) > data.CastRange)
                            endpos = startpos.To2D() + direction * data.CastRange;

                        if (startpos.To2D().Distance(endpos) < data.CastRange && iscone)
                            endpos = startpos.To2D() + direction * data.CastRange;

                        var proj = hero.Player.ServerPosition.To2D().ProjectOn(startpos.To2D(), endpos);
                        var projdist = hero.Player.ServerPosition.To2D().Distance(proj.SegmentPoint);

                        int evadetime = 0;

                        if (islineskillshot)
                            evadetime = (int)(1000 * (correctwidth - projdist + hero.Player.BoundingRadius) / hero.Player.MoveSpeed);

                        if (!islineskillshot)
                            evadetime = (int)(1000 * (correctwidth - hero.Player.Distance(startpos) + hero.Player.BoundingRadius) /hero.Player.MoveSpeed);

                        if ((!islineskillshot || iscone) && hero.Player.Distance(endpos) <= correctwidth + hero.Player.BoundingRadius + 35 ||
                            islineskillshot && correctwidth + hero.Player.BoundingRadius + 35 > projdist)
                        {
                            
                            if (hero.Player.NetworkId == Activator.Player.NetworkId &&
                                (data.Global || Activator.Origin.Item("evade").GetValue<bool>()))
                            {
                                if (hero.Player.CanMove && evadetime < endtime)
                                {
                                    continue;
                                }
                            }

                            if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                                continue;

                            var dmg = (int) Math.Abs(attacker.GetSpellDamage(hero.Player, args.SData.Name));

                            Utility.DelayAction.Add((int)(endtime - (endtime * 0.3)), () =>
                            {
                                hero.Attacker = attacker;
                                hero.HitTypes.Add(HitType.Spell);
                                hero.IncomeDamage += dmg;

                                if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.Danger);
                                if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.CrowdControl);
                                if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.Ultimate);
                                if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.ForceExhaust);

                                Utility.DelayAction.Add((int) endtime + 250, () =>
                                {
                                    hero.Attacker = null;
                                    hero.IncomeDamage -= dmg;
                                    hero.HitTypes.Remove(HitType.Spell);

                                    if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.Danger);
                                    if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.CrowdControl);
                                    if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.Ultimate);
                                    if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.ForceExhaust);
                                });
                            });
                        }
                    }

                    #endregion

                    #region unit type

                    if (args.SData.TargettingType == SpellDataTargetType.Unit ||
                        args.SData.TargettingType == SpellDataTargetType.SelfAndUnit)
                    {
                        if (args.Target == null)
                            continue;

                        // check if is targeteting the hero on our table
                        if (hero.Player.NetworkId != args.Target.NetworkId)
                            continue;

                        // target spell dectection
                        if (hero.Player.Distance(attacker.ServerPosition) > data.CastRange)
                            continue;

                        var distance = (int)(1000 * (attacker.Distance(hero.Player.ServerPosition) / data.MissileSpeed));
                        var endtime = data.Delay - 100 + Game.Ping / 2 + distance - (Utils.GameTimeTickCount - LastCastedTimeStamp);

                        if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                            continue;

                        var dmg = (int)Math.Abs(attacker.GetSpellDamage(hero.Player, args.SData.Name));

                        Utility.DelayAction.Add((int)(endtime - (endtime * 0.7)), () =>
                        {
                            hero.Attacker = attacker;
                            hero.HitTypes.Add(HitType.Spell);
                            hero.IncomeDamage += dmg;

                            if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                hero.HitTypes.Add(HitType.Danger);
                            if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                hero.HitTypes.Add(HitType.CrowdControl);
                            if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                hero.HitTypes.Add(HitType.Ultimate);
                            if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                hero.HitTypes.Add(HitType.ForceExhaust);

                            // lazy reset
                            Utility.DelayAction.Add((int) endtime + 250, () =>
                            {
                                hero.Attacker = null;
                                hero.IncomeDamage -= dmg;
                                hero.HitTypes.Remove(HitType.Spell);

                                if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.Danger);
                                if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.CrowdControl);
                                if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.Ultimate);
                                if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                    hero.HitTypes.Remove(HitType.ForceExhaust);
                            });
                        });
                    }
                    #endregion
                }
            }

            #endregion

            #region Turret

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Turret && args.Target.Type == Activator.Player.Type)
            {
                var turret = sender as Obj_AI_Turret;
                if (turret == null || turret.IsAlly || !turret.IsValid<Obj_AI_Turret>())
                    return;

                foreach (var hero in Activator.Allies())
                {
                    if (args.Target.NetworkId == hero.Player.NetworkId && !hero.Immunity)
                    {
                        var dmg = (int)Math.Abs(turret.CalcDamage(hero.Player, Damage.DamageType.Physical,
                            turret.BaseAttackDamage + turret.FlatPhysicalDamageMod));

                        if (turret.Distance(hero.Player.ServerPosition) <= 900)
                        {
                            if (Activator.Player.Distance(hero.Player.ServerPosition) <= 1000)
                            {
                                Utility.DelayAction.Add(450, () =>
                                {
                                    hero.HitTypes.Add(HitType.TurretAttack);
                                    hero.TowerDamage += dmg;

                                    Utility.DelayAction.Add(150, () =>
                                    {
                                        hero.Attacker = null;
                                        hero.TowerDamage -= dmg;
                                        hero.HitTypes.Remove(HitType.TurretAttack);
                                    });
                                });
                            }
                        }
                    }
                }
            }

            #endregion

            #region Minion

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Minion && args.Target.Type == Activator.Player.Type)
            {
                var minion = sender as Obj_AI_Minion;
                if (minion == null || minion.IsAlly || !minion.IsValid<Obj_AI_Minion>())
                    return;

                foreach (var hero in Activator.Allies())
                {
                    if (hero.Player.NetworkId == args.Target.NetworkId && !hero.Immunity)
                    {
                        if (hero.Player.Distance(minion.ServerPosition) <= 750)
                        {
                            if (Activator.Player.Distance(hero.Player.ServerPosition) <= 1000)
                            {
                                hero.HitTypes.Add(HitType.MinionAttack);
                                hero.MinionDamage =
                                    (int)Math.Abs(minion.CalcDamage(hero.Player, Damage.DamageType.Physical,
                                        minion.BaseAttackDamage + minion.FlatPhysicalDamageMod));

                                Utility.DelayAction.Add(250, () =>
                                {
                                    hero.HitTypes.Remove(HitType.MinionAttack);
                                    hero.MinionDamage = 0;
                                });
                            }
                        }
                    }
                }
            }

            #endregion

            #region Gangplank Barrel

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Hero)
            {
                var attacker = sender as Obj_AI_Hero;
                if (attacker.ChampionName != "Gangplank" || !attacker.IsValid<Obj_AI_Hero>() || attacker.IsAlly)
                    return;

                foreach (var hero in Activator.Allies())
                {
                    // reset if needed
                    Essentials.ResetIncomeDamage(hero.Player);

                    foreach (
                        var obj in ObjectManager.Get<GameObject>()
                            .Where(x => x.Name.Contains("E_AoE") && x.Position.Distance(x.Position) <= 400)
                            .OrderBy(y => y.Position.Distance(hero.Player.ServerPosition)))
                    {
                        if (hero.Player.Distance(obj.Position) > 400 || args.Target.Name != "Barrel")
                        {
                            continue;
                        }

                        var dmg = (int)Math.Abs(attacker.GetAutoAttackDamage(hero.Player, true) * 1.6 + 200);
                        if (args.SData.Name.ToLower().Contains("crit"))
                        {
                            dmg = dmg * 2;
                        }

                        if (!hero.Player.IsValidTarget(float.MaxValue, false) || hero.Player.IsZombie || hero.Immunity)
                        {
                            hero.Attacker = null;
                            hero.IncomeDamage = 0;
                            hero.HitTypes.Clear();
                            continue;
                        }

                        Utility.DelayAction.Add(100, () =>
                        {
                            hero.Attacker = attacker;
                            hero.HitTypes.Add(HitType.Spell);
                            hero.IncomeDamage += dmg;

                            Utility.DelayAction.Add(400, delegate
                            {
                                hero.Attacker = null;
                                hero.HitTypes.Remove(HitType.Spell);
                                hero.IncomeDamage -= dmg;
                            });
                        });
                    }
                }
            }

            #endregion

            #region Heimerdinger Turret

            if (sender.IsEnemy && Activator.Heroes.Any(x => x.Player.IsValidTarget() && x.Player.ChampionName == "Heimerdinger"))
            {
                if (args.Target.Type != Activator.Player.Type)
                    return;

                var attacker = sender as Obj_AI_Hero;
                if (attacker == null || attacker.IsAlly || !attacker.IsValid<Obj_AI_Hero>())
                    return;

                foreach (var hero in Activator.Allies())
                {
                    // reset if needed
                    Essentials.ResetIncomeDamage(hero.Player);

                    if (args.SData.Name.ToLower() == "heimertyellowbasicattack" ||
                        args.SData.Name.ToLower() == "heimertyellowbasicattack2")
                    {
                        if (args.Target.NetworkId == hero.Player.NetworkId)
                        {
                            var dmg = (int) Math.Abs(attacker.GetAutoAttackDamage(hero.Player, true));

                            Utility.DelayAction.Add(350, () =>
                            {
                                hero.Attacker = attacker;
                                hero.HitTypes.Add(HitType.AutoAttack);
                                hero.IncomeDamage += dmg;

                                Utility.DelayAction.Add(150, delegate
                                {
                                    hero.Attacker = null;
                                    hero.IncomeDamage -= dmg;
                                    hero.HitTypes.Remove(HitType.AutoAttack);
                                });
                            });
                        }
                    }
                }
            }

            #endregion

            #region Items

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Hero)
            {
                var attacker = sender as Obj_AI_Hero;
                if (attacker == null || attacker.IsAlly || !attacker.IsValid<Obj_AI_Hero>())
                    return;

                foreach (var hero in Activator.Allies())
                {
                    // reset if needed
                    Essentials.ResetIncomeDamage(hero.Player);

                    if (args.Target.NetworkId != hero.Player.NetworkId)
                    {
                        continue;
                    }

                    if (args.SData.Name.ToLower() == "bilgewatercutlass")
                    {
                        var dmg = (float) attacker.GetItemDamage(hero.Player, Damage.DamageItems.Bilgewater);

                        hero.Attacker = attacker;
                        hero.HitTypes.Add(HitType.AutoAttack);
                        hero.IncomeDamage += dmg;

                        Utility.DelayAction.Add(250, () =>
                        {
                            hero.Attacker = null;
                            hero.HitTypes.Remove(HitType.AutoAttack);
                            hero.IncomeDamage -= dmg;
                        });
                    }

                    if (args.SData.Name.ToLower() == "itemswordoffeastandfamine")
                    {
                        var dmg = (float) attacker.GetItemDamage(hero.Player, Damage.DamageItems.Botrk);

                        hero.Attacker = attacker;
                        hero.HitTypes.Add(HitType.AutoAttack);
                        hero.IncomeDamage += dmg;

                        Utility.DelayAction.Add(250, () =>
                        {
                            hero.Attacker = null;
                            hero.HitTypes.Remove(HitType.AutoAttack);
                            hero.IncomeDamage -= dmg;
                        });
                    }

                    if (args.SData.Name.ToLower() == "hextechgunblade")
                    {
                        var dmg = (float) attacker.GetItemDamage(hero.Player, Damage.DamageItems.Hexgun);

                        hero.Attacker = attacker;
                        hero.HitTypes.Add(HitType.AutoAttack);
                        hero.IncomeDamage += dmg;

                        Utility.DelayAction.Add(250, () =>
                        {
                            hero.Attacker = null;
                            hero.HitTypes.Remove(HitType.AutoAttack);
                            hero.IncomeDamage -= dmg;
                        });
                    }
                }
            }

            #endregion
        }

    }
}