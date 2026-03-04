// Задание 1:

{
    int number = 10;
    if (number > 0)
    {
        Console.WriteLine("Число положительное");
    }
    else if (number < 0)
    {
        Console.WriteLine("Число отрицательное");
    }
    else
    {
        Console.WriteLine("Число равно нулю");
    }
}
// Задание 2:
{
    Console.Write("Введите возраст: ");
    int age = int.Parse(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("Вы совершеннолетний");
    }
    else
    {
        Console.WriteLine("Вы несовершеннолетний");
    }
}
// Задание 3:
{
    int number = 7;
    if (number % 2 == 0)
    {
        Console.WriteLine("Число чётное");
    }
    else
    {
        Console.WriteLine("Число нечётное");
    }
}
// Задание 4:
{
    int a = 5, b = -2;
    if(a > 0 && b > 0)
    {
        Console.WriteLine("Оба числа положительные");
    }
    if(a > 0 || b > 0)
    {
        Console.WriteLine("Одно из чисел положительное");
    } 
    if(a <= 0)
            {
        Console.WriteLine("a не положительное");
    }
}
// Задание 5:
{
    Console.Write("Введите оценку (от 2 до 5): ");
    int num = int.Parse(Console.ReadLine());
    if (num < 3)
    {
        Console.WriteLine("Неудовлетворительно");
    }
    else if(num == 3)
    {
        Console.WriteLine("Удовлетворительно");
    }
    else if(num == 4)
    {
        Console.WriteLine("Хорошо");
    }
    else if(num == 5)
    {
        Console.WriteLine("Отлично");
    }
    else
    {
        Console.WriteLine("Неккоректная оценка");
    }
}