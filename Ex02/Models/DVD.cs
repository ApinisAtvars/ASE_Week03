public class DVD : LibraryItem
{
    public int Duration;

    public DVD(string id, string title, int year, int duration) : base(id, title, year)
    {
        Duration = duration;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Duration: {Duration}");
    }
}