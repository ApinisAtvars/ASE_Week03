public class Wine : Collectible
{
    public double PricePerGlass { get; set; }
    public string Country { get; set; }
    public WineType TypeOfWine { get; set; }

    public Wine(string name, int yearoforigin, double price, double priceperglass, string country, WineType typeofwine) : base(name, yearoforigin, price)
    {
        PricePerGlass = priceperglass;
        Country = country;
        TypeOfWine = typeofwine;
    }

    public override string ToString()
    {
        return $"Wine: {Name} ({Country})";
    }

    public override string CollectType
    {
        get
        {
            return "Wine";
        }
    }
}