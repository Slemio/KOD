{
    Console.Write("Введите первое число, a = ");
    float a = float.Parse(Console.ReadLine());
    Console.Write("Введите второе число, b = ");
    float b = float.Parse(Console.ReadLine());
    float sum = a + b;
    float diff1 = a - b;
    float diff2 = b - a;
    float prod = a * b;
    float div1 = a / b;
    float div2 = b / a;
    Console.WriteLine($"{a} + {b} = {sum}");
    Console.WriteLine($"{a} - {b} = {diff1}");
    Console.WriteLine($"{b} - {a} = {diff2}");
    Console.WriteLine($"{a} * {b} = {prod}");
    Console.WriteLine($"{a} / {b} = {div1}");
    Console.WriteLine($"{b} / {a} = {div2}");
}