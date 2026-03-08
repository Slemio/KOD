// Задание 2:
int[] numbers = { 1, 7, 5, 9, 2 };
Console.WriteLine("Числа в прямом порядке: ");
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($" {numbers[i]}");
    }
}
Console.WriteLine("Числа в обратном порядке: ");
{
    for (int i = numbers.Length -1; i >= 0; i--)
    {
        Console.WriteLine($" {numbers[i]}");
    }
}
