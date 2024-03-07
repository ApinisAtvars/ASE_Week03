public class Teacher : Person
{
    public Teacher(string firstName, string lastName) : base(firstName, lastName)
    {
        Console.WriteLine("Constructor Teacher");
    }

    public override void Study()
    {
        Console.WriteLine("Teacher study time!!!!!!!!.....");
    }
}