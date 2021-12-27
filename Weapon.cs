using System;

namespace Encapsulation_task_1
{
    public class Weapon
    {
        private const int BulletsPerShot = 1;

        private readonly int _damage;
        private int _bullets;

        public Weapon(int damage, int bullets)
        {
            if (damage < 0)
                throw new ArgumentOutOfRangeException(nameof(damage));

            if (bullets < 0)
                throw new ArgumentOutOfRangeException(nameof(bullets));

            _damage = damage;
            _bullets = bullets;
        }

        public void Fire(Player player)
        {
            if (_bullets < BulletsPerShot)
                throw new ArgumentException(nameof(_bullets));

            player.TakeDamage(_damage);
            _bullets -= BulletsPerShot;
        }
    }
}
