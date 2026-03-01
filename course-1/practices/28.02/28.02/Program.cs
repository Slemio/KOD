{
    int a = 12;
    int b = 5;
    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    int sum = a + b;
    int diff = a - b;
    int prod = a * b;
    int div = a / b;
    int mod = a % b;
    Console.WriteLine($"Сумма: {a} + {b} = {sum}");
    Console.WriteLine($"Разность: {a} - {b} = {diff}");
    Console.WriteLine($"Произведение: {a} * {b} = {prod}");
    Console.WriteLine($"Частное : {a} / {b} = {div}");
    Console.WriteLine($"Остаток от деления: {a} % {b} = {mod}");
    Console.Write("Введите ваше имя:");
    string name = Console.ReadLine();
    Console.WriteLine($"Привет,{name}!");
}