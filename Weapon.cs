namespace Grinding
{
    internal class Weapon
    {
        private const int BULLETSPERSHOT = 1;

        private int _bullets;

        public bool CanShoot() => _bullets >= BULLETSPERSHOT;

        public void Shoot() => _bullets -= BULLETSPERSHOT;
    }
}
