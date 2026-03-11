using System;

class Player
{
    private int health = 100;

    public event Action<int> DamageTaken;
    
    public void TakeDamage(int damagae)
    {
        health -= damagae;
        Console.WriteLine($"플레이어 체력: {health}");
        DamageTaken?.Invoke(health);
    }
}