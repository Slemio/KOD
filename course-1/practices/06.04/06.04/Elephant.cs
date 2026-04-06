public class Elephant : Animal
{
    public Elephant() : base("Слон") { }
    public Elephant(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Трууу!");
        MakeSound();
    }
}
