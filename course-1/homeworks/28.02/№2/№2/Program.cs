{
    Console.Write("Введите первое число: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Введите третье число: ");
    int c = int.Parse(Console.ReadLine());
    int d = (a + b + c) / 3;
    Console.WriteLine($"Среднее арифметическое = ({a} + {b} + {c})/3 = {d}");
}
