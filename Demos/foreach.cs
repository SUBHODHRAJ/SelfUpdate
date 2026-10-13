using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Numbers in the array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}