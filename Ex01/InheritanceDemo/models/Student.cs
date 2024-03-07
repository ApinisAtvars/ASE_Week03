public class Student : Person       //When we create a student, the compiler creates a Person
{
    public Student(string firstName, string lastName) : base(firstName, lastName)       //The "base" calls the constructor from the base class and passes the data
    {
        Console.WriteLine("Constructor Student");
        base.Calculate();
    }

    public override void Study()
    {
        Console.WriteLine("STUDENT Study time...");
    }
}