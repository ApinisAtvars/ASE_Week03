public class ComicBook : Collectible
{
    public string Publisher { get; set; }
    public string Author { get; set; }


    public ComicBook(string name, int yearoforigin, double price, string publisher, string author) : base(name, yearoforigin, price)
    {
        Publisher = publisher;
        Author = author;
    }

    public override string ToString()
    {
        return $"Comic Book: {Name} ({Author})";
    }

    public override string CollectType
    {
        get
        {
            return "Comic book";
        }
    }
}