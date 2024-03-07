public class Book : LibraryItem
{
    public string Author { get; set; }
    public Book(string id, string title, int year, string author) : base(id, title, year)
    {
        Author = author;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Author: {Author}");
    }
}