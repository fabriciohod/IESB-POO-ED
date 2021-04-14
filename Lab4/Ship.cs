using System;

namespace Lab4
{
    public abstract class Ship : IDamageable
    {
        public string Name { get; protected set; }
        public int Energy { get; protected set; }
        public ShipMover Position { get; protected set; }
        public Gun ShipGun { get; protected set; }

        protected Ship(string name, int energy, ShipMover position, Gun shipGun)
        {
            Name = name;
            Energy = energy;
            Position = position;
            ShipGun = shipGun;
        }

        public virtual void MoveTo(Vector2 newPosition, Asteroid[] asteroids, Ship[] ships)
        {
            foreach (var ship in ships)
            {
                if (newPosition != ship.Position.CurrentPosition())
                    continue;

                Console.WriteLine("Nao e possivel ir para essa posicao, pois ja existe uma nave la");
                return;
            }

            foreach (var asteroid in asteroids)
            {
                if (newPosition != asteroid.Position())
                    continue;

                TakeDamage();
                Console.WriteLine($"Voce bateu em um asteroide, voce recebeu 1 de dano, sua energia atual e {Energy}");
                return;
            }

            Position.MoveToPosition(newPosition);
            Console.WriteLine("Voce chegou a nova posicao com sucesso!");
        }

        public virtual void ShotTarget(Ship target, Vector2 targetPosition)
        {
            Console.WriteLine($"{Name} is attacking {target.Name} at {target.Position.CurrentPosition()}," +
                $"\nthe projectale vector is {Position.CurrentPosition() - target.Position.CurrentPosition()}");

            if (ShipGun.Shot(target))
            {
                Console.WriteLine($"{target.Name} has ben destroyed");
            }
        }

        public virtual bool TakeDamage(int damage = 1)
        {
            Energy -= damage;

            return Energy <= 0;
        }
    }
}