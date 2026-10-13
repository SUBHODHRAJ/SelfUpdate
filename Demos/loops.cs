using System;

class Loops
{
    static void Main()
    {

        Console.WriteLine("For loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteration {i}");
        }

        Console.WriteLine("\nWhile loop:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine($"Iteration {j}");
            j++;
        }

        Console.WriteLine("\nDo-while loop:");
        int k = 0;
        do
        {
            Console.WriteLine($"Iteration {k}");
            k++;
        } while (k < 5);
    }
}