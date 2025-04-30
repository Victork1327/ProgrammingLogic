class Book
{
    private string title;
    private string? author;

    public Book()  // Default Constructor
    {
        title = "Unknown Title";
    }
    public Book(string titlename)//adding a prameterised constructor
    {
        title = titlename;
    }
    public Book(string titlename, string authorname) //creating constructor overload
    {
        title = titlename;
        author = authorname;
    }
    public void SetTitle(string newTitle) //finished the example given with a set title method
    {
        this.title = newTitle;
    }
    public string GetTitle()
    {
        return title;
    }
    public void SetAuthor (string newAuthor)
    {
        this.author = newAuthor;
    }               //making a new set and get method for the author field now
    public string GetAuthor()
    {
        return author!;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals
        
        Book book2 = new Book("Learning C#"); //immedaitly defining the title
        Console.WriteLine(book2.GetTitle());

        Book book3 = new Book("Advanced C#", "John Doe");//using a comma to define both variables of the overload
        Console.WriteLine("Title: " + book3.GetTitle());//using the get methhod to print them
        Console.WriteLine("Author: "+ book3.GetAuthor());

        Book book4 = new Book();//redefining the feilds with the getter setter method
        book4.SetAuthor("Jane Smith");
        book4.SetTitle("Mastering C#");
        Console.WriteLine("Title: " + book4.GetTitle());
        Console.WriteLine("Author: "+ book4.GetAuthor());

    }
}
