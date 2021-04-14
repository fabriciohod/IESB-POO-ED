using System;

namespace Lab4
{
    public class WarShip : Ship
    {
        public WarShip(string name, int energy, ShipMover position, Gun shipGun) : base(name, energy, position, shipGun)
        {
        }
    }
}