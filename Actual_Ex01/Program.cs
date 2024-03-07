Animal cow = new Animal("Daisy", 10);
Dog dog = new Dog("Rocket", 5, "Retriever");

cow.MakeSound();
dog.MakeSound();

Console.WriteLine(cow.Name);
Console.WriteLine(cow.Age);

Console.WriteLine(dog.Name);
Console.WriteLine(dog.Age);
Console.WriteLine(dog.Breed);