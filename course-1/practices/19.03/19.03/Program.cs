public class Animal
{
   public string Name { get; set; }
    // По заданию 1: Eat()
    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }
    // По заданию 2: виртуальный метод Speek()
    public virtual void Speak()
    {
        Console.WriteLine("Животное издаёт звук");
    }
    // По заданию 3: виртуальный метод Move()
    public virtual void Move()
    {
        Console.WriteLine("Животное двигается");
    }
    // По заданию 4: конструктор с именем и базовый (без параметров) для совместимости с первыми заданиями
    public Animal() { }
    public Animal(string name) 
    {
        Name = "name";
        Console.WriteLine($"Создано животное с {name}");
    }
}
public class Dog : Animal 
{
    public Dog() { }
    public Dog(string name) : base(name) { }
    // Задание 1: Лай
    public void Bark()
    {
        Console.WriteLine("Собака лает");
    }
    public override void Speak()
    {
        Console.WriteLine("Собака говорит: Гав-Гав!");
    }
    public override void Move()
    {
        base.Move();
        Console.WriteLine("Собака бежит по дороге");
    }
}
public class Cat : Animal
{
    // Задание 4: конструктор, вызывающий base(name)
    public Cat() { }
    public Cat(string name) : base(name) 
    { 
        Console.WriteLine($"Создана кошка по имени {name}");
    }
    // Задание 1: Мяуканье
    public void Meow()
    {
        Console.WriteLine("Кошка мяукает");
    }
    // Задание 2: Речь
    public override void Speak()
    {
        Console.WriteLine("Кошка говорит: Мяу!");
    }
    // Move() не переопределяем
}
public class Transport
{
    public virtual void Drive()
    {
        Console.WriteLine("Транспорт движется");
    }
}
    public class Car : Transport
{
    public override void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}
public class ElectricCar : Transport
{
    public override void Drive()
    {
        Console.WriteLine("Электромобиль тихо едет на батарее");
    }
}