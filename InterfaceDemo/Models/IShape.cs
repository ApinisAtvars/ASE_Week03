public interface IShape
{
    //Define methods: Each shape needs these 2 methods
    double CalculateArea();
    void Display();
    //Define property: Each shape must have this property
    int Thickness { get; set; }

}
