using System;
using static System.Net.Mime.MediaTypeNames;

class Player : IDamageable
{
    public int Health { get; private set; } = 100;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"플레이어가 {damage} 대미지를 받음. 남은 체력: {Health}");
    }
}

class Enemy : IDamageable
{
    public int Health { get; private set; } = 50;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"적이 {damage} 대미지를 받음. 남은 체력: {Health}");
    }
}

class Building : IDamageable
{
    public int Health { get; private set; } = 500;

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"건물이 {damage} 대미지를 받음. 남은 내구도: {Health}");
    }
}