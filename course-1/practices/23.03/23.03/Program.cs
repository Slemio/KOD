public class Person
{
    private string _name;
    private int _age;
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Ошибка: имя не может быть пустым");
            }
            else
            {
                _name = value;
            }
        }
    }
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Ошибка: возраст не может быть отрицательным");
            }
            else
            {
                _age = value;
            }
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Имя: {Name}, возраст: {Age} ");
    }
    public void Show()
    {
        var p = new Person();
        p.Name = "Алиса";
        p.Age = 25;
        p.Age = -5;
    }
        }
public class BankAccount
{
    private decimal balance;
    public void Deposite(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Ошибка: сумма должна быть положительной");
            return;
        }
        balance += amount;
        Console.WriteLine($"Пополнение на {amount} руб. Новый баланс: {balance}");
    } 
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Ошибка: сумма должна быть положительной");
            return;
        }
        if(amount > balance)
        {
            Console.WriteLine("Недостаточно средств на счёте");
            return;
        }
        balance -= amount;
        Console.WriteLine($"Снятие {amount} руб. Остаток: {balance}");
    }
    public void ShowBalance()
    {
        Console.WriteLine($"Текущий баланс: {balance}");
    }
}
public class Thermometer
{
    private double TemperatureC;
    public double TemperatureCelsius
    {
        get => TemperatureC;
        set
        {
            if(value < -273)
            {
                Console.WriteLine("Ошибка: температура не может быть ниже абсолютного нуля (-273.C)");
            }
            else
            {
                TemperatureC = value;
            }
        }
    }
    public double TemperatureF => (TemperatureC * 9 / 5) + 32;
    public void ShowTemperature()
    {
        Console.WriteLine($"Температура: {TemperatureC}.C = {TemperatureF}.F");
    }
}