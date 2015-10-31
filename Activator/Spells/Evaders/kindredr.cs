using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activator.Base;
using LeagueSharp.Common;

namespace Activator.Spells.Evaders
{
    class kindredr : CoreSpell
    {
        internal override string Name
        {
            get { return "kindredr"; }
        }

        internal override string DisplayName
        {
            get { return "Lamb's Respite| R"; }
        }

        internal override float Range
        {
            get { return 400f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.Zhonyas }; }
        }

        internal override int DefaultHP
        {
            get { return 10; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (Parent.Item(Parent.Name + "useon" + hero.Player.NetworkId).GetValue<bool>())
                {
                    if (hero.Player.Distance(Player.ServerPosition) <= Range)
                    {
                        if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                            if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger))
                                UseSpellOn(hero.Player);

                        if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                            if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                                UseSpellOn(hero.Player);
                    }
                }
            }
        }
    }
}
