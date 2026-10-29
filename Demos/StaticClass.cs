using System;

class Test
{
    static void Main(string[] args)
    {
        FinalClass fc = new FinalClass();
        fc.Display();
        Console.WriteLine($"Sum: {Calculator.Add(10, 20)} Difference: {Calculator.Sub(10, 5)} Product: {Calculator.Mul(10, 20)}");
    }
}
static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Sub(int a, int b)
    {
        return a - b;
    }

    public static int Mul(int a, int b)
    {
        return a * b;
    }
}

sealed class FinalClass
{
    public void Display()
    {
        Console.WriteLine("This is a final class.");
        int sum = Calculator.Add(5, 3);
        int difference = Calculator.Sub(5, 3);
        int product = Calculator.Mul(5, 3);
        Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}");
    }
}




