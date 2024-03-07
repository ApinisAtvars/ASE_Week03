public class Dog : Animal
{
    public string Breed { get; set; }
    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}