using System;

namespace Lab4
{
    public class ShipMover
    {
        private Vector2 position;
        public int Speed { get; private set; }
        public int FuelLevel { get; private set; }

        /// <summary>
        /// The initial position would be in 0, 0 and the starting fuel in 100
        /// </summary>
        public ShipMover()
        {
            position = new Vector2(0, 0);
            FuelLevel = 100;
        }

        /// <summary>
        /// Set the initial position of the ship and the starting fuel
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public ShipMover(Vector2 startPosition, int fuelLevel)
        {
            position = startPosition;
            FuelLevel = fuelLevel;
        }

        public void MoveToPosition(Vector2 newPosition)
        {
            position.MoveTo(newPosition);
        }

        public Vector2 CurrentPosition()
        {
            return position.CurrentPosition();
        }
    }
}