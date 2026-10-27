
using System;

interface IShape
{
    void Area();
    void Perimeter();
}
class Circle : IShape
{
    public void Area()
    {
        Console.WriteLine("Area of Circle = π * r^2");
    }
    public void Perimeter()
    {
        Console.WriteLine("Perimeter of Circle = 2 * π * r");
    }
}
class Program
{
    static void Main()
    {
        IShape s = new Circle();

        s.Area();
        s.Perimeter();
    }
}
