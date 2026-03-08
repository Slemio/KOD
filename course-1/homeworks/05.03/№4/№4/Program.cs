// Задание 4:
int passwordtrue = 1234;
int attempts = 3;
for (int i = 0; i < attempts; i++)
{
    Console.Write(" Введите пароль: ");
    int password = int.Parse(Console.ReadLine());
    if (password == passwordtrue)
    {
        Console.WriteLine(" Доступ разрешён");
        break;
    }
    else
    {
        Console.WriteLine(" Пароль неверный");
    }
    if (i == attempts - 1)
    {
        Console.WriteLine(" Доступ запрещён");
    }
}
