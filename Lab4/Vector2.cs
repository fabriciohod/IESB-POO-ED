using System;

namespace Lab4
{
    public struct Vector2
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public Vector2(int x, int y) =>
            (this.x, this.y) = (x, y);

        public void MoveTo(Vector2 newPosition) =>
            (x, y) = (newPosition.x, newPosition.y);

        public Vector2 CurrentPosition() => this;

        public static Vector2 operator -(Vector2 p1, Vector2 p2)
        {
            var xAxix = p1.x - p2.x;
            var yAxix = p1.y - p2.y;

            return new Vector2(xAxix, yAxix);
        }

        public static bool operator ==(Vector2 p1, Vector2 p2)
        {
            bool checkX = p1.x == p2.x;
            bool checkY = p1.y == p2.y;

            return checkX && checkY;
        }
        public static bool operator !=(Vector2 p1, Vector2 p2)
        {
            bool checkX = p1.x == p2.x;
            bool checkY = p1.y == p2.y;

            return !(checkX && checkY);
        }

        public override string ToString()
        {
            return $"X: {x}, Y:{y}";
        }
    }
}