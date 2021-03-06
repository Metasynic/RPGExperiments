﻿
namespace RPGExperiments.Equipment
{
    public static class WeaponTypes
    {
        public static readonly WeaponType Shortsword = new WeaponType(1.2, 1.0, 1d/16d);
        public static readonly WeaponType Broadsword = new WeaponType(1.0, 1.1, 1d/16d);
        public static readonly WeaponType Dagger = new WeaponType(0.75, 1.0, 1d/16d);
        public static readonly WeaponType Spear = new WeaponType(1.25, 0.8, 1d/16d);
        public static readonly WeaponType Axe = new WeaponType(0.6, 1.2, 1d/16d);
        public static readonly WeaponType Bow = new WeaponType(0.9, 0.85, 1d/16d);
        public static readonly WeaponType Staff = new WeaponType(1.0, 0.8, 1d/32d);
        public static readonly WeaponType Rod = new WeaponType(0.8, 0.8, 1d/32d);
        public static readonly WeaponType Unarmed = new WeaponType(1.0, 1.0, 1d/32d);
        public static readonly WeaponType Fists = new WeaponType(1.0, 1.4, 1d/16d);
    }

    public struct WeaponType
    {
        // These are ratings between 0 and 1 for modifying weapon power and hit rate.
        public double Hit { get; }
        public double Pow { get; }
        public double Crit { get; }

        public WeaponType(double h, double p, double c)
        {
            Hit = h;
            Pow = p;
            Crit = c;
        }
    }
}
