using System;

class Loops
{
    static void Main()
    /*{


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

    {
        Console.WriteLine("Loops in C#");
        int a = 0;
        int b = 1;
        Console.Write("Enter the number of terms : ");
        int k = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("Fibonacci number of " + i + " is : " + a);
            int c = a + b;
            a = b;
            b = c; 
        }
    }*/

    {
        Console.WriteLine("Getting Array Input from user");
        Console.Write("Enter the size of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter element (press Enter to enter number one by one ):");
        for(int i =0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nSorting the array in ascending order");

        Array.Sort(arr);
        for(int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}