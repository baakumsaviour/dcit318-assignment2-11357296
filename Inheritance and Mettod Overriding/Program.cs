// Animal.cs
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Dog.cs
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Cat.cs
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}
class program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        myAnimal.MakeSound();
        myDog.MakeSound();
        myCat.MakeSound();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}