public class CalculatorService
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    //We have 2 methods with the same name, but we overload the parameters.
    public double Add(double a, double b)
    {
        return a + b;
    }
}