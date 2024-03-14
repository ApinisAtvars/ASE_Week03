public class Boat : Vehicle
{
    string TypeOfWater { get; }

    public Boat(string color, string typeofwater) : base(color)
    {
        TypeOfWater = typeofwater;
    }

    public override string DescribeVehicle()
    {
        return $"Type: Boat, Color: {Color}, Speed: {Speed}, Type of water: {TypeOfWater}";
    }

}