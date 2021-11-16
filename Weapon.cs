using System;

public class Weapon
{
    private readonly int _damage;
    private int _bullets;

    public Weapon(int damage, int startBulletsCount)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        if (startBulletsCount < 0)
            throw new ArgumentOutOfRangeException(nameof(startBulletsCount));

        _damage = damage;
        _bullets = startBulletsCount;
    }

    public void Fire(Player player)
    {
        if (_bullets > 0)
        {
            player.TakeDamage(_damage);
            _bullets -= 1;
        }
        else
        {
            throw new ArgumentException(nameof(_bullets));
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
            throw new ArgumentException(nameof(_health));
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