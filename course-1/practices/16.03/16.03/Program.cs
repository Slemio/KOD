using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

public class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Pages { get; }
    public Book()
        {
        Title = "Неизвестно";
            Author = "Неизвестен";
        Pages = 0;
    }
    public Book(string title)
    {
        Title = "Название книги";
        Author = "Неизвестен";
        Pages = 0;
    }
    public Book(string title, string author)
    {
        Title = "Название книги";
        Author = "Автор";
        Pages = 0;
    }
    public Book(string title, string author, int pages)
    {
        Title = "Название книги";
        Author = "Автор";
        Pages = 20;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Pages}");
    }
}
public class Car
{
    public string Brand { get; }
    public string Model { get; }
    public int Speed { get; private set; }
    public Car() : this("Неизвестно", "Неизвестно") { }
    public Car(string brand) : this(brand, "Неизвестно") { }
    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
        Speed = 0;
    }
    public void Accelerate()
    {
        Speed += 10;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"{Brand}, {Model}, скорость: {Speed} км/час");
    }
}
public class Player
{
    public string Name { get; }
    public int Level { get; }
    public Player(string name, int level)
    {
        Name = name;
        Level = Level;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"{Name}, уровень {Level}");
    }
    public override bool Equals(object? obj)
    {
        if (obj is Player other)
            return Name == other.Name && Level == other.Level;
        return false;

        var p1 = new Player("Alex", 5);
        var p2 = new Player("Alex", 5);
        var p3 = p1;
        Console.WriteLine(p1 == p2);
        Console.WriteLine(p1 == p3);
        Console.WriteLine(p1.Equals(p2));
    }
}
public class User()
{
    public string Login { get; set; }
    private string password;
    public string Password
    {
        get => password;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                password = value;
                Console.WriteLine("Пароль обновлён");
            }
            else
            {
                Console.WriteLine("Ошибка: пароль не может быть пустым");
            }
        }
    }
    public bool CheckPassword(string input)
    {
        return Password == input;
        string userPassword;
        var user = new User { Login = "admin" };
        userPassword = "12345";
        Console.WriteLine(user.CheckPassword("12345"));
        userPassword = "";
    }
}