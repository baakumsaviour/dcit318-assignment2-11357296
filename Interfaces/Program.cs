using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Move();

        Bicycle bicycle = new Bicycle();
        bicycle.Move();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}


