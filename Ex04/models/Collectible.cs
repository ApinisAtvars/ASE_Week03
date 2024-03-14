using System.Runtime.CompilerServices;

public abstract class Collectible : IComparable
{
    public string Name { get; set; }
    public int YearOfOrigin { get; set; }
    public double Price { get; set; }
    public double StartBidPrice;
    public abstract string CollectType { get; }

    public Collectible(string name, int yroforg, double prc)
    {
        Name = name;
        YearOfOrigin = yroforg;
        Price = prc;
        StartBidPrice = 0.8 * Price;

    }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;
        Collectible other = (Collectible)obj;
        // If you want to compare by name

        // return this.Name.CompareTo(other.Name);

        //If you want to compare by price

        return this.Price.CompareTo(other.Price);

    }
}