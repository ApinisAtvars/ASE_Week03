public abstract class Vehicle
{
    public int Speed { get; set; }
    public string Color { get; }

    public Vehicle(string color)
    {
        Color = color;
    }

    public abstract string DescribeVehicle();
}