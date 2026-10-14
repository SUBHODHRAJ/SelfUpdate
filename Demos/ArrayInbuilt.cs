using System;
using System.Linq;
class TestArray
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        int b = Array.IndexOf(a, 3);
        Array.Reverse(a);
        Console.WriteLine(PrintArray(a));
        Console.WriteLine(b);
        Array.Sort(a);
        Console.WriteLine(PrintArray(a));
        Console.WriteLine("Rank of the array is: " + a.Rank);
        Console.WriteLine("Sum of the array is: " + a.Sum());
        Console.WriteLine("Average of the array is: " + a.Average());
        Console.WriteLine("Max of the array is: " + a.Max());
        Console.WriteLine("Min of the array is: " + a.Min());
    }

    static string PrintArray(int[] a)
    {
        string s = "";
        for (int i = 0; i < a.Length; i++)
        {
            s += a[i] + " ";
        }
        return s;
    }
}