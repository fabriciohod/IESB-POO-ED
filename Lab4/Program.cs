using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            WarShip bobNelson = new("Bob Nelson", 10, new ShipMover(new Vector2(10, 10), 200), new Gun(1));

            WarShip[] pirates = 
            {
                new("Barba estrelada", 3, new ShipMover(new Vector2(20, 20), 100), new Gun(3)),
                new("Caos estelar", 3, new ShipMover(new Vector2(40, 40), 90), new Gun(6)),
                new("Gigante gasoso", 3, new ShipMover(new Vector2(60, 60), 300), new Gun(10))
            };

            Asteroid[] asteroids = 
            {
                new(2, new Vector2(15, 8)),
                new(2, new Vector2(25, 18)),
                new(2, new Vector2(30, -30)),
                new(2, new Vector2(45, 10)),
                new(2, new Vector2(100, 30))
            };

            bobNelson.MoveTo(new Vector2(10,10), asteroids, pirates);
            bobNelson.ShotTarget(pirates[0], pirates[0].Position.CurrentPosition());
        }
    }
}
