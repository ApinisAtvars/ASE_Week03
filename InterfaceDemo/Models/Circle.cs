public class Circle : IShape
{
    public void Display()
    {
        Console.WriteLine($"Circle Area: {CalculateArea()}");
    }


    public Circle(double radius)
    {
        Radius = radius;
    }


    public int Thickness { get; set; }
    public double Radius { get; set; }


    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}