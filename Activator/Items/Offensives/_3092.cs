using System;
using Activator.Base;
using LeagueSharp.Common;

namespace Activator.Items.Offensives
{
    class _3092 : CoreItem
    {
        internal override int Id 
        {
            get { return 3092; }
        }

        internal override int Priority
        {
            get { return 6; }
        }

        internal override string Name 
        {
            get { return "Queens"; }
        }

        internal override string DisplayName
        {
            get { return "Frost Queen's Claim"; }
        }

        internal override float Range
        {
            get { return 1550f; }
        }

        internal override int Duration
        {
            get { return 2000; }
        }

        internal override int DefaultHP
        {
            get { return 55; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.EnemyLowHP, MenuType.SelfLowHP }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
           {
               if (hero.Attacker != null && hero.Attacker.IsValidTarget(900))
               {
                   if (!Parent.Item(Parent.Name + "useon" + hero.Attacker.NetworkId).GetValue<bool>())
                       return;

                   if (hero.Player.Distance(Player.ServerPosition) <= Range)
                   {
                       if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                           Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                       {
                            UseItem();
                       }
                   }
               }
           }

            if (Tar != null)
            {
                if (!Parent.Item(Parent.Name + "useon" + Tar.Player.NetworkId).GetValue<bool>())
                    return;

                if (Tar.Player.Health / Tar.Player.MaxHealth * 100 <= Menu.Item("enemylowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    UseItem();
                }
            }
        }
    }
}
