using System;

class Constructorss
{
    static Constructorss()
    {
        Console.WriteLine("Static constructor called.");
    }

    static void display()
    {
        Console.WriteLine("Instance method called.");
    }

    static void Main()
    {
        Constructorss.display();
    }
}