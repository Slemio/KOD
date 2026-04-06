public class Cat : Animal
{
    public Cat() : base("Кошка") { }
    public Cat(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Мяу!");
        MakeSound();
    }
}
