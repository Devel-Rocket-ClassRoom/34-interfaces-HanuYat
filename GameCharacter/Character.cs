using System;

class Character : IAttacker, IDefender
{
    public string Name { get; }
    public int MaxHp { get; private set; } = 100;
    public int AttackPower { get; private set; } = 20;
    public int CurrentHp { get; private set; }
    public bool IsDead { get; private set; }

    public void Attack(IDefender defender)
    {

    }

    public void TakeDamage(int damage)
    {

    }
}