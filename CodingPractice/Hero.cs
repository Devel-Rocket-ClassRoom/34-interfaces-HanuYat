using System;

class Hero : IMoveable, IAttackable
{
    public void Move()
    {
        Console.WriteLine("영웅이 이동합니다.");
    }

    public void Attack()
    {
        Console.WriteLine("영웅이 공격합니다.");
    }
}

class Turret : IAttackable
{
    public void Attack()
    {
        Console.WriteLine("포탑이 발사합니다.");
    }
}