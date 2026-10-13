using System;

public class Fibonacci
{
    public static long fib(int n)
    {
        if (n <= 1) return n;
        return fib(n - 1) + fib(n - 2);
    }

    public static void Main()
    {   
        Console.Write("Enter the number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < terms; i++)
        {
            Console.WriteLine($"i is {i}: {fib(i)} ");
        }
        Console.WriteLine();
    }
}
