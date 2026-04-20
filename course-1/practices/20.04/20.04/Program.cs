using System.Security.Cryptography.X509Certificates;

public class PublishingHouse
{

    public string Name { get; set; }
    public PublishingHouse(string name) {  Name = name; }
    public void ShowInfo()
    {
        Console.WriteLine($"Издательство: {Name}");
    }
}
public class Book
{
    private int _year;
    private string _author;
    private int _pages;
    private string _title;
    public string Title
    {
        get => _title;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _title = value;
            }
        }
    }
    public int Year
    {
        get => _year;
        set
        {
            if (_year > 0)
            {
                Year = value;
            }
        }
    }
    public string Author
    {
        get => _author;
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                _author = value;
            }
        }
    }
    public int Pages
    {
        get => _pages;
        set
        {
            if (value > 0)
            {
                _pages = value;
            }
        }
    }
    public Book(string title, string author, int year, int pages)
    {
        Title = title;
        Author = author;
        Year = year;
        Pages = pages;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Автор: {Author}, Кол-во страниц: {Pages}, Год издания: {Year}, Название: {Title}.");
    }
}
public class TextBook : Book
{
    public string Subject { get; set; }
    public TextBook(string title, string author, int year, int pages, string subject)
       : base(title, author, year, pages)
    {
        Subject = subject;
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"Автор: {Author}, Кол-во страниц: {Pages}, Год издания: {Year}, Название: {Title}, Предмет: {Subject}.");
    }
}
public class FictionBook : Book
{
    public string Genre { get; set; }
    public FictionBook(string title, string author, int year, int pages, string genre)
       : base(title, author, year, pages)
    {
        Genre = genre;
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"Автор: {Author}, Кол-во страниц: {Pages}, Год издания: {Year}, Название: {Title}, Жанр: {Genre}.");
    }
}
public class Reader
{
    public string Name { get; set; }
    public int Id { get; set; }
    private List<Book> _borrowedBooks = new List<Book>();
    public Reader(string name, int id)
    {
        Name = name;
        Id = id;
    }
    public void BorrowBook(Book book)
    {
        _borrowedBooks.Add(book);
        Console.WriteLine($"{Name} взял книгу \"{book.Title}\"");
    }
    public void Show_BorrowedBooks()
    {
        Console.WriteLine($"Книги у {Name}:");
        foreach(var book in _borrowedBooks)
        {
            book.ShowInfo();
        }
    }
}