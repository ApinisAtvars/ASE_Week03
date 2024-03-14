using System.ComponentModel;

Car car1 = new Car("Red", 4);
Car car2 = new Car("Blue", 4);
Car car3 = new Car("Green", 4);


Boat boat1 = new Boat("White", "Freshwater");
Boat boat2 = new Boat("Blue", "Saltwater");
Boat boat3 = new Boat("Green", "Brackishwater");


List<Vehicle> vehicles = new List<Vehicle>()
{
    car1,
    car2,
    car3,
    boat1,
    boat2,
    boat3
};

foreach (Vehicle vehicle in vehicles)
{
    vehicle.Speed = 5;
    string description = vehicle.DescribeVehicle();
    Console.WriteLine(description);
    if (vehicle is IRefuelable rf)
    {
        rf.Refuel();
    }
}