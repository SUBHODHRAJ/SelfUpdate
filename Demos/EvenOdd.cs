using System;
using System.Collections.Generic;

class OddandEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Enter a non-negative number.");
            return;
        }

        List<int> even = new List<int>();
        List<int> odd = new List<int>();

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                even.Add(i);
            else
                odd.Add(i);
        }

        Console.WriteLine("Even numbers:");
        foreach (int x in even)
            Console.Write(x + " ");

        Console.WriteLine("\nOdd numbers:");
        foreach (int x in odd)
            Console.Write(x + " ");

        int evenCount = n / 2 + 1;
        int oddCount = (n + 1) / 2;

        int[] neweve = new int[evenCount];
        int[] newodd = new int[oddCount];

        int e = 0, o = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                neweve[e++] = i;
            else
                newodd[o++] = i;
        }

        Console.WriteLine("\nEven numbers using array:");
        Console.WriteLine(string.Join(" ", neweve));

        Console.WriteLine("Odd numbers using array:");
        Console.WriteLine(string.Join(" ", newodd));
    }
}