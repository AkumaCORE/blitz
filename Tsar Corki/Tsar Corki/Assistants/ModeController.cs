﻿using EloBuddy;
using EloBuddy.SDK;

namespace Tsar_Corki
{
    public static class ModeController
    {
        static ModeController()
        {
            Game.OnTick += OnTick;
        }

        private static void OnTick(System.EventArgs args)
        {
            if (OrbCombo)
                Modes.Combo.Execute();

            if (OrbHarass)
                Modes.Harass.Execute();

            if (OrbLaneClear)
                Modes.Clear.Execute();

            if (OrbJungleClear)
                Modes.Jungle.Execute();

            if (OrbFlee && Return.UseWFlee)
                Modes.Flee.Execute();
        }

        // Return Orbwalker Modes
        public static bool OrbCombo
        {
            get
            {
                return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo);
            }
        }

        public static bool OrbHarass
        {
            get
            {
                return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Harass);
            }
        }

        public static bool OrbLaneClear
        {
            get
            {
                return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LaneClear);
            }
        }

        public static bool OrbJungleClear
        {
            get
            {
                return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.JungleClear);
            }
        }

        public static bool OrbFlee
        {
            get
            {
                return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Flee);
            }
        }


        public static void Initialize()
        {
        }
    }
}
