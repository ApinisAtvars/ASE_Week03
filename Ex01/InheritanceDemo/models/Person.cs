public abstract class Person //ABSTRACT keyword means that you cannot directly create an instance of this class
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)        //Student class calls this with "base"
    {
        FirstName = firstName;
        LastName = lastName;
        Console.WriteLine("Constructor Person");
    }

    protected int Calculate()
    {
        return 0;
    }

    public abstract void Study();
}