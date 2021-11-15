using System;

public class Weapon
{
    private readonly int _damage;
    private int _bulletsCount;

    public Weapon(int damage, int startBulletsCount)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        if (startBulletsCount < 0)
            throw new ArgumentOutOfRangeException(nameof(startBulletsCount));

        _damage = damage;
        _bulletsCount = startBulletsCount;
    }

    public void Fire(Player player)
    {
        if (_bulletsCount > 0)
        {
            player.TakeDamage(_damage);
            _bulletsCount -= 1;
        }
        else
        {
            Console.WriteLine("Weapon empty.");
        }
    }
}

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
        if (damage < _health)
        {
            _health -= damage;
        }
        else
        {
            _health = 0;
            Console.WriteLine("Player died.");
        }
    }
}

public class Bot
{
    private readonly Weapon _weapon;

    public Bot(Weapon weapon)
    {
        _weapon = weapon;
    }

    public void OnSeePlayer(Player player)
    {
        _weapon.Fire(player);
    }
}