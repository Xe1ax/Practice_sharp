namespace Task_1
{
    class Book
    {
        private string title;  
        private string author; 
        private int pages; 
        private double price;  

        public Book(string title, string author, int pages, double price)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.price = price;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Название книги: " + title);
            Console.WriteLine("Автор книги: " + author);
            Console.WriteLine("Количество страниц: " + pages);
            Console.WriteLine("Стоимость книги: " + price);
        }
    }

    class HardcoverBook : Book
    {
        private string coverMaterial;  

        public HardcoverBook(string title, string author, int pages, double price, string coverMaterial) : base(title, author, pages, price)
        {
            this.coverMaterial = coverMaterial;
        }

        public string CoverMaterial
        {
            get { return coverMaterial; }
            set { coverMaterial = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Материал обложки: " + coverMaterial);
            Console.WriteLine("Стоимость с учетом надбавки за обложку: " + (Price + 50));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HardcoverBook book = new HardcoverBook("Мастер и Маргарита", "Михаил Булгаков", 480, 500, "Кожа");

            book.Print();

            Console.ReadKey();
        }
    }
}