public class Magazine : LibraryItem
{
    public int IssueNumber;

    public Magazine(string id, string title, int year, int issuenumber) : base(id, title, year)
    {
        IssueNumber = issuenumber;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine($"Issue number: {IssueNumber}");
    }
}