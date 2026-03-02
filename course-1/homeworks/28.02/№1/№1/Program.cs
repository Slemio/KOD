{
    Console.Write("Введите температуру в градусах Цельсия:");
    int C = int.Parse(Console.ReadLine());
    int F = C * 9 / 5 + 32;
    Console.WriteLine($" {C} градусов Цельсия = {F} градусов Фаренгейта");
        }
