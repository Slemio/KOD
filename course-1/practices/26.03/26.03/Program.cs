public class Animal
{
    public virtual void Speek()
    {
        Console.WriteLine("Животное издаёт звук");
    }
}
public class Dog : Animal
{
    public override void Speek()
    {
         Console.WriteLine("Собака говорит: Гав-гав!");
    }
}
public class Cat : Animal
{
    public override void Speek()
    {
        Console.WriteLine("Кошка говорит: Мяу!");
    }
}
public class Cow : Animal
{
    public override void Speek()
    {
        Console.WriteLine("Корова говорит: Муу!");
    }
}
public class Transport
{
    public string Model { get; set; }
    public virtual void Move()
    {
        Console.WriteLine($"{Model}: транспорт движется");
    }
}
public class Car : Transport
{
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Машина едет по дороге");
    }
}
public class Boat : Transport
{
    public override void Move()
    {
        Console.WriteLine("Лодка плывёт по воде");
    }
}
public class Plane : Transport
{
    public override void Move()
    {
        Console.WriteLine("Самолёт летит в небе");
    }
}
public abstract class Shape
{
    public abstract double GetArea();
}
public class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
}
public class Square : Shape
{
    public double Side { get; set; }
    public override double GetArea() => Side * Side;
}
public class Rectangle : Shape
{
    public double Wight { get; set; }
    public double Height { get; set; }
    public override double GetArea() => Wight * Height;
}
public class Instrument
{
    public virtual void Play()
    {
        Console.WriteLine("Инструмент издаёт звук");
    }
}
public class Guitar : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Гитара играет аккорды");
    }
}
public class Piano : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Пианино играет мелодию");
    }
}
public class Drum : Instrument
{
    public override void Play()
    {
        Console.WriteLine("Барабан отбивает ритм");
    }
}
public abstract class Character
{
    public string Name { get; set; }
    public abstract void Attack();
}
public class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine("Воин атакует мечом!");
    }
}
public class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Маг выпускает огненный шар!");
    }
}
public class Archer : Character
{
    public override void Attack()
    {
        Console.WriteLine("Лучник стреляет из лука!");
    }
}