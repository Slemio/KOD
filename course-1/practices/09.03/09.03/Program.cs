using System.Diagnostics.Metrics;

class Program
{
    // Задание 1:
    static void SayHello()
    {
        Console.WriteLine("Привет, мир!");
        SayHello();
        SayHello();
        SayHello();
        Console.WriteLine();
    }
    // Задание 2:
    static void Greet(string name)
    {
        Console.WriteLine($"Привет, {name}!");
        Greet("Саша");
        Greet("Ярослав");
        Greet("Анна");
        Console.WriteLine();
    }
    // Задание 3:
    static void PrintPerson(string name, int age, string city)
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Город: {city}");
        PrintPerson("Егор", 15, "Москва");
        PrintPerson("Анна", 25, "Санкт-Петербург");
        Console.WriteLine();
    }
    // Задание 4:

    static void PrintPerson1(string name, int age = 18, string hobby = "Не указано")
        => Console.WriteLine($"Имя: {name}, Возраст: {age}, Хобби: {hobby}");
    // Задание 5:
    static int Square(int x)
    {
        return x * x;
    }
    // Задание 6:
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;

    static double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Деление на ноль запрещено");
        return (double)a / b;
    }
    static int ReadInt()
    {
        while (true)
        {
            string? s = Console.ReadLine();
            if (int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out int val)) ;
            return val;
            Console.Write("Введите корректное целое число: ");
        }
    }
    // Задание 7:
    static int counter = 0;
    static void Increment()
    {
        counter++;
    }
    static void Main()
    {
        Console.WriteLine("Начаьное значение counter:" + counter);
        Increment();
        Console.WriteLine("После 1-го вызова:" + counter);
        Increment();
        Console.WriteLine("После 2-го вызова:" + counter);
        Increment();
        Console.WriteLine("После 3-го вызова:" + counter);
    }
    // Задание 8:
    static int Multiply0(int a, int b)
    {
        return a * b;
    }
    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
}
