public class Car : Vehicle, IRefuelable
{
    public int NumberOfWheels { get; set; }

    public Car(string color, int numberofwheels) : base(color)
    {
        NumberOfWheels = numberofwheels;
    }

    public override string DescribeVehicle()
    {
        return $"Type: Car, Color: {Color}, Speed: {Speed}, Number of wheels: {NumberOfWheels}";
    }

    public void Refuel()
    {
        Console.WriteLine("Refuelling car...");
    }
}