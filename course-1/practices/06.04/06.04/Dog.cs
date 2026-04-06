public class Dog : Animal
{
    public Dog() : base("Собака") { }
    public Dog(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Гав");
        MakeSound();
    }
}