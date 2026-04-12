public class Exercise_1
{
    public abstract class Worker
    {
        public string name = "Неизвестно";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract void Work();
        public void ShowInfo()
        {
            Console.WriteLine($"Работник: {Name}");
        }
    }
    public class Manager : Worker
    {
        public override void Work()
        {
            Console.WriteLine("Планирует задачи");
        }
    }
    public class Developer : Worker
    {
        public override void Work()
        {
            Console.WriteLine("Пишет код");
        }
    }
    public void Test()
    {
        Worker[] workers = { new Manager { Name = "Анна" }, new Developer { Name = "Иван" } };
        foreach (var w in workers)
        {
            w.ShowInfo();
            w.Work();
        }
    }
}
public class Exercise_2
{
    public abstract class CookingProcess
    {
        public void Подготовка_ингредиентов()
        {
            Console.WriteLine("Подготовка ингредиентов");
        }
        public abstract void Процесс_приготовления();
        public void Подача_блюда()
        {
            Console.WriteLine("Подача готового блюда");
        }
        public void Готовка()
        {
            Подготовка_ингредиентов();
            Процесс_приготовления();
            Подача_блюда();
        }
    }
    public class Soup : CookingProcess
    {
        public override void Процесс_приготовления()
        {
            Console.WriteLine("Варение супа");
        }
    }
    public class Steak : CookingProcess
    {
        public override void Процесс_приготовления()
        {
            Console.WriteLine("Обжарка стейка");
        }
    }
}