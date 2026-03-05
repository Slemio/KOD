// Задание 1: Создание массива
{
    int[] numbers1 = { 10, 20, 30, 40, 50 };
    for (int i = 0; i < numbers1.Length; i++)
    {
        Console.Write(numbers1[i] + " ");
    }
}
// Задание 2: Поиск среднего арифметического
{
    int[] grades = { 5, 4, 3, 5, 2, 4 };
    int sum = 0;
    for (int i = 0; i < grades.Length; i++)
    {
        sum += grades[i];
    }
    double average = (double)sum / grades.Length;
    Console.WriteLine($"Среднее значение: {average:F2}");
}
// Задание 3: Поиск максимального значения
{
    Random rand = new Random();
    int[] numbers2 = new int[8];
    for (int i = 0; i < numbers2.Length; i++)
    {
        numbers2[i] = rand.Next(1, 101);
        Console.Write(numbers2[i] + " ");
    }
    Console.WriteLine();
    int max = numbers2[0];
    for (int i = 1; i < numbers2.Length; i++)
    {
        if (numbers2[i] > max)
            max = numbers2[i];
    }
    Console.WriteLine($"Максимальное число: {max}");
}
// Задание 4: Работа с foreach
{
    string[] fruits = { "Яблоко", "Банан", "Апельсин", "Киви", "Груша" };
    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
    Console.WriteLine();
}
// Задание 5: Двухмерный массив
{
    int[,] matrix = new int[3, 3];
    int counter = 1;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matrix[i, j] = counter++;

            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// Задание 6: Ввод пароля (do .. while) до "1234"
{
    string passwordTrue = "1234";

    string password;
    do
    {
        Console.Write("Введите пароль: ");
        password = Console.ReadLine();
    } while (password != passwordTrue);
}