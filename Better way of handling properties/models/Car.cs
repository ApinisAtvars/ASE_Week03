using System.Runtime.InteropServices;

public class Car
{

    //This is called an autoproperty
    public string Brand { get; set; }
    //If we need to check something in the setter, we need to use the traditional
    //way of writing properties (eg releaseYear)
    private int _releaseYear;

    public int ReleaseYear
    {
        get
        {
            return _releaseYear;
        }
        set
        {
            if (value < 1900)
            {
                throw new Exception("Error");
            }
            _releaseYear = value;
        }
    }
}