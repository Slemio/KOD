// Задание 1:
float[] grate = { 5, 2, 3, 4, 5, 2, 5 };
{
    float sum = 0;
    for (int i = 0; i < grate.Length; i++)
        sum = sum + grate[i];
    float ar = sum / 7;
    Console.WriteLine("Оценки = 5, 2, 3, 4, 5, 2, 5");
    Console.WriteLine($"Среднее арифметическое = {ar}");
}
{
    int c = 0;
    for (int i = 0; i < grate.Length; i++)
        if (grate[i] == 5)
        {
            c++;
        }
    Console.WriteLine($"Количество пятёрок = {c}");
}
{
    int c = 0;
    for (int i = 0; i < grate.Length; i++)
        if (grate[i] == 2)
        {
            c++;
        }
    Console.WriteLine($"Количество двоек = {c}");
}
