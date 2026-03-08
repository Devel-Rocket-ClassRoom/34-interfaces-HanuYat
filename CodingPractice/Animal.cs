using System;

class Animal
{
    public void Breathe()
    {
        Console.WriteLine("숨을 쉽니다.");
    }
}

class Bird : Animal, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("날아갑니다.");
    }
}