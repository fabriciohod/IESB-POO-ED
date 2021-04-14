using System;

namespace Lab4
{
    public struct Gun
    {
        public int ShotPower { get; private set; }
        public int ProjectleSpeed { get; private set; }

        public Gun(int fireRate, int shotPower = 1) =>
            (ShotPower, ProjectleSpeed) = (shotPower, fireRate);

        public bool Shot(IDamageable target)
        {
           return target.TakeDamage(ShotPower);
        }
    }
}