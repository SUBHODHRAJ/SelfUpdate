using System;

class WhileLoop
{
    public static void Main()
    {
        int a = 0;
        int b = 1;
        int count = 0;

        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibonacci Series:");
        while (count < n)
        {
            Console.Write(a + " ");
            int c = a;
            a = b;
            b = c + b;
            count++;
        }

        Console.WriteLine();
    }
}