using System;

class GameCharacter
{
    private int health = 100;

    public event Action OnDeath;
    public event Action<int> OnDamaged;
    public event Action<int, string> OnAttack;

    public void Attack(int damage, string target)
    {
        OnAttack?.Invoke(damage, target);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        OnDamaged?.Invoke(health);

        if (health <= 0)
        {
            OnDeath?.Invoke();
        }
    }
}