public class Movie
{
    public string Title { get; }
    public string Genre { get; }
    public int Rating { get; private set; }
    public Movie() : this("Без названия", "Неизвестно", 0) { }
    public Movie(string title) : this(title, "Неизвестно", 0) { }
    public Movie(string title, string genre, int rating)
    {
        Title = title;
        Genre = genre;
        Rating = rating;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
    }
    public override bool Equals(object? obj)
    {
        if (obj is Movie other)
            return Title == other.Title && Genre == other.Genre && Rating == other.Rating;
        return false;
    }
    public void TestMovie()
    {
        var m1 = new Movie();
        var m2 = new Movie("Матрица");
        var m3 = new Movie("Начало", "Фантастика", 9);
        m1.PrintInfo();
        m2.PrintInfo();
        m3.PrintInfo();
    }
}
public class Device 
{ 
    public string Name { get; set;  }
    public virtual void Beep()
    {
        Console.WriteLine("Устройство подаёт сигнал");
    }
    public void TurnOn()
    {
        Console.WriteLine("Устройство включено");
    }
    public class Kettle : Device
    {
        public override void Beep()
        {
            Console.WriteLine("Чайник пикнул: пи-пи!");
        }
        public void Boil()
        {
            Console.WriteLine("Чайник кипятит воду");
        }
    }
    public class Toaster : Device
    {
        public override void Beep()
        {
            Console.WriteLine("Тостер пикнул: динь!");
        }
        public void Toast()
        {
            Console.WriteLine("Тостер поджаривает хлеб");
        }
    }
    public void Test()
    {
        var kettle = new Kettle();
        kettle.Name = "Redmond";
        kettle.TurnOn();
        kettle.Boil();
        kettle.Beep();
        var toaster = new Toaster();
        toaster.Name = "Philips";
        toaster.TurnOn();
        toaster.Toast();
        toaster.Beep();
    }
}