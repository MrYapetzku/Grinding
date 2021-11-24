using System;

namespace Encapsulation_task_1
{
    public class Player
    {
        private int _health;

        public Player(int startHealth)
        {
            if (startHealth <= 0)
                throw new ArgumentOutOfRangeException(nameof(startHealth));

            _health = startHealth;
        }

        public void TakeDamage(int damage)
        {
            if (damage > _health)
            {
                _health = 0;
                throw new ArgumentOutOfRangeException(nameof(_health));
            }
            else
            {
                _health -= damage;
            }
        }
    }
}