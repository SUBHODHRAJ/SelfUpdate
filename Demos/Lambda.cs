using System;

class Delegate
{
    public void Functions()
    {
        Func<int, int, int> Square = (x, y) => x * y;
        Console.WriteLine("The square of 5 is: " + Square(5, 5));
        Action<int> Greet = age => Console.WriteLine("You are an adult.") ;
        Greet(25);
    }
    static void Main(string[] args)
    {
        Delegate del = new Delegate();
        del.Functions();
    }
}