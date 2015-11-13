using System;
using Activator.Base;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace Activator.Summoners
{
    class teleport : CoreSum
    {
        internal override string Name
        {
            get { return "summonerteleport"; }
        }

        internal override string DisplayName
        {
            get { return "Teleport"; }
        }

        internal override string[] ExtraNames
        {
            get { return new[] { "" }; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override int Duration
        {
            get { return 3500; }
        }

        private static int _lastPing;
        private static Vector3 _lastPingLocation;

        // ping credits to Honda :^)
        private static void Ping(Vector3 pos)
        {
            if (Utils.GameTimeTickCount - _lastPing < 5000)
            {
                return;
            }

            _lastPing = Utils.GameTimeTickCount;
            _lastPingLocation = pos;

            SimplePing();
            Utility.DelayAction.Add(150, SimplePing);
            Utility.DelayAction.Add(300, SimplePing);
            Utility.DelayAction.Add(400, SimplePing);
            Utility.DelayAction.Add(800, SimplePing);
        }

        private static void SimplePing()
        {
            Game.ShowPing(PingCategory.Danger, _lastPingLocation, true);
        }

        public override void OnTick(EventArgs args)
        {
            if (!IsReady())
            {
                return;
            }

            foreach (var hero in Activator.Allies())
            {
                if (!Parent.Item(Parent.Name + "useon" + hero.Player.NetworkId).GetValue<bool>())
                    continue;

                if (hero.Player.Distance(Player.ServerPosition) > 3000 && hero.Player.Distance(Game.CursorPos) > 3000)
                {
                    if (hero.HitTypes.Contains(HitType.Ultimate) && Menu.Item("teleult").GetValue<bool>())
                    {
                        if (hero.IncomeDamage > 0)
                        {
                            Ping(hero.Player.ServerPosition);
                        }
                    }

                    if (hero.Player.Health / hero.Player.MaxHealth * 100 <= 35 && Menu.Item("telehp").GetValue<bool>())
                    {
                        if (hero.IncomeDamage > 0)
                        {
                            Ping(hero.Player.ServerPosition);
                        }
                    }
                }
            }
        }
    }
}
