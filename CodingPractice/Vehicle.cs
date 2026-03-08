using System;

abstract class Vehicle
{
    public abstract void Back();

    public void Left()
    {
        Console.WriteLine("좌회전");
    }
}

class Car3 : Vehicle, IStandard
{
    public override void Back()
    {
        Console.WriteLine("후진");
    }

    public void Run()
    {
        Console.WriteLine("전진");
    }
}