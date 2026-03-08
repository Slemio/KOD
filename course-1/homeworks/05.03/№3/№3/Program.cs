// Задание 3:
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 1)
    {
        continue;
    }
    Console.Write($"{numbers[i]} ");
}
