public class LibraryItem
{
    public string ID { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }

    public LibraryItem(string id, string title, int year)
    {
        ID = id;
        Title = title;
        Year = year;
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine($"Id: {ID}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Year: {Year}");
    }
}