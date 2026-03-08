using System;

// README.md를 읽고 코드를 작성하세요.

Car car = new();
car.Go();
Console.WriteLine();

IRepository repo = new Repository();
repo.Get();
Console.WriteLine();

Person person = new Person();
person.Work();
person.Rest();
Console.WriteLine();

Car2 car1 = new Car2(new GoodBattery());
car1.Run();
Car2 car2 = new Car2(new NormalBattery());
car2.Run();
Console.WriteLine();

Dog dog = new();
dog.Eat();
dog.Bark();
Console.WriteLine();

Bird bird = new Bird();
bird.Breathe();
bird.Fly();
Console.WriteLine();

Pet pet = new Pet();
((IDog2)pet).Eat();
((ICat2)pet).Eat();

IDog2 dog2 = new Pet();
dog2.Eat();
ICat2 cat2 = new Pet();
cat2.Eat();
Console.WriteLine();

IExample example = new Example();
example.DoWork();
Console.WriteLine();

TextEditor textEditor = new TextEditor();
textEditor.Undo();
textEditor.Redo();
Console.WriteLine();

Car3 car3 = new Car3();
car3.Run();
car3.Left();
car3.Back();
Console.WriteLine();

Player player = new Player();
Enemy enemy = new Enemy();
Building building = new Building();
Attack(player,20);
Attack(enemy, 30);
Attack(building, 100);

void Attack(IDamageable target, int damage)
{
    target.TakeDamage(damage);
}
Console.WriteLine();

Hero hero = new Hero();
hero.Move();
hero.Attack();

Turret turret = new Turret();
turret.Attack();