public class Rectangle : IShape
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Thickness { get; set; }

    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public void Display()
    {
        Console.WriteLine($"The area of the rectangle is {CalculateArea()}");
    }

    public double CalculateArea()
    {
        return Length * Width;
    }

}