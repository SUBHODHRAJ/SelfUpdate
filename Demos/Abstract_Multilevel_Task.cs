
using System;

abstract class Shape
{
    public abstract void Area();
    public abstract void Perimeter();
    public abstract void Radii();

    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

class Circle : Shape
{
    public override void Area()
    {
        Console.WriteLine("Area of Circle = π * r^2");
    }

    public override void Perimeter()
    {
        Console.WriteLine("Perimeter of Circle = 2 * π * r");
    }

    public override void Radii()
    {
        Console.WriteLine("Radius of Circle = r");
    }
}

class Radius : Shape
{
    public override void Area()
    {
        Console.WriteLine("Area of Circle = π * r^2");
    }

    public override void Perimeter()
    {
        Console.WriteLine("Perimeter of Circle = 2 * π * r");
    }

    public override void Radii()
    {
        Console.WriteLine("Radius of Circle = r");
    }
}

class Program
{
    static void Main()
    {
        Shape f = new Circle();
        Shape r = new Radius();

        f.Display();
        f.Area();
        f.Perimeter();

        r.Radii();
    }
}
