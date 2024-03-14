public class PostStamp : Collectible
{
    public string Image { get; set; }

    public PostStamp(string name, int yearoforigin, double price, string image) : base(name, yearoforigin, price)
    {
        Image = image;
    }

    public override string ToString()
    {
        return $"Poststamp: {Image}";
    }

    public override string CollectType
    {
        get
        {
            return "Post stamp";
        }
    }
}