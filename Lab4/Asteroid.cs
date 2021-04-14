using System;

namespace Lab4
{
    public class Asteroid : IDamageable
    {
        public int Hp { get; private set; }
        private Vector2 position;

        public Asteroid(int hp, Vector2 StartingPosition)
        {
            Hp = hp;
            position = StartingPosition;
        }

        public bool TakeDamage(int damage = 1)
        {
            Hp -= damage;

            return Hp <= 0;
        }

        public Vector2 Position()
        {
            return position.CurrentPosition();
        }
    }
}