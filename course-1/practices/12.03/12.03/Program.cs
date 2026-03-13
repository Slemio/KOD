    public class Car
{
    public string Brand {  get; set; } // Марка авто
    public int Speed { get; private set; } // Текущая скорость
    public Car(string Brand, int Speed)
    {
        Brand = "BMW";
        Speed = 10;
    }
    public void Accelerate()
    {
        Speed += 10;
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set;  }
    public int Pages { get; set;  }
    private int _pagesread;
    public Book(string title, string author, int pages)
    {
        Title = title;
        Pages = pages;
        _pagesread = 0;
    }
    public void Read(int pages)
    {
        // ограничиваем кол-во прочитанных страниц
        if (_pagesread + pages > Pages)
        {
            pages = Pages - _pagesread;
            _pagesread += Pages;
            Console.WriteLine($"Вы прочитали {_pagesread} из {Pages}");
        }
    } }
public class Library
{
    private List<Book> books = new List<Book> ();
    // Добавляем книги
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Книга \"{book.Title}\" добавлена в библиотеку");
    }
    // Печать всех книг
    public void PrintAllBooks()
    {
        Console.WriteLine("Список в библиотеке: ");
        if (books.Count == 0)
        {
            Console.WriteLine("Библиотека пуста");
            return;
        }
    }
}