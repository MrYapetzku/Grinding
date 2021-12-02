using System;

namespace Encapsulation_task_1
{
    public class Player
    {
        private int _health;

        public Player(int health)
        {
            if (health <= 0)
                throw new ArgumentOutOfRangeException(nameof(health));

            _health = health;
        }

        public void TakeDamage(int damage)
        {
            if (damage > _health)
            {
                throw new ArgumentOutOfRangeException(nameof(_health));
            }
            else
            {
                _health -= damage;
            }
        }
    }
}
