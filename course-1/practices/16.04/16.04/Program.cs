    public interface Iplayable
    {
        void Play();
    }
    public class Guitar : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Гитара играет аккорды.");
        }
    }
    public class Piano : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Пианино играет мелодию.");
        }
    }
    public class Drums : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Барабаны отбивают ритм.");
        }
    }
    class Program
    {
        static void Main()
        {
            Iplayable[] instruments = { new Guitar(), new Piano(), new Drums() };
            foreach (var c in instruments)
            {
                c.Play();
            }
        }
    }
    public interface IReadable
    {
        public void Read(string filename);
    }
    public interface IWriteable
    {
        public void Write(string filename, string content);
    }
    public interface ISaveable
    {
        void Save();
    }
    public class TextDocument : IReadable, IWriteable, ISaveable
    {
        private string content;
        public void Read(string filename)
        {
            Console.WriteLine($"Чтение из файла {filename}");
            content = "Текст из файла";
        }
        public void Write(string filename, string content)
        {
            Console.WriteLine($"Запись в файл {filename}: {content}");
            this.content = content;
        }
        public void Save()
        {
            Console.WriteLine($"Файл сохранён. Содержимое {content}");
        }
    }
    class Program2
    {
        static void Main2()
        {
            TextDocument doc = new TextDocument();
            doc.Read("data.txt");
            doc.Write("data.txt", "Привет, мир!");
            doc.Save();
        }
    }
    public interface IDocumentExporter
    {
        string FormatName { get; }
        public void Export(string content);
        public void ShowInfo(string content)
        {
            Console.WriteLine($"Экспорт в формат {FormatName}: {content}");
        }
    }
    public class TXTExporter : IDocumentExporter
    {
        public string FormatName => "TXT";
        public void Export(string content)
        {
            Console.WriteLine("Сохраняем текстовый файл...");
        }
    }
    public class PDFExporter : IDocumentExporter
    {
        public string FormatName => "PDF";
        public void Export(string content)
        {
            Console.WriteLine("Создаём PDF-документ");
        }
    }
    class Program3
    {
        static void Main3()
        {
            IDocumentExporter[] exporters = { new TXTExporter(), new PDFExporter() };
            foreach (var c in exporters)
            {
                c.ShowInfo("Привет, мир");
                c.Export("Привет, мир");
            }
        }
    }