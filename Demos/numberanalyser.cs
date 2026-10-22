
using System;

class Program
{
    static void Main()
    {
        int[] a = new int[8];
        int i = 0;
        while (i < 8)
        {
            Console.Write("Enter number: ");

            if (int.TryParse(Console.ReadLine(), out a[i]))
                i++;
            else
                Console.WriteLine("Enter a valid integer!");
        }
        int even = 0, odd = 0, pos = 0, neg = 0, zero = 0;
        for (i = 0; i < 8; i++)
        {
            if (a[i] % 2 == 0)
                even++;
            else
                odd++;
            if (a[i] > 0)
                pos++;
            else if (a[i] < 0)
                neg++;
            else
                zero++;
        }
        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
        Console.WriteLine("Positive: " + pos);
        Console.WriteLine("Negative: " + neg);
        Console.WriteLine("Zero: " + zero);
        
        int largest = int.MinValue;
        int second = int.MinValue;

        for (i = 0; i < 8; i++)
        {
            if (a[i] > largest)
            {
                second = largest;
                largest = a[i];
            }
            else if (a[i] > second && a[i] != largest)
            {
                second = a[i];
            }
        }

        if (second == int.MinValue)
            Console.WriteLine("No second largest number");
        else
            Console.WriteLine("Second largest: " + second);

        Console.WriteLine("Original array: ");
        for (i = 0; i < 8; i++)
            Console.Write(a[i] + " ");

        Console.Write("Reversed array: ");

        for (i = 7; i >= 0; i--)
            Console.Write(a[i] + " ");
    }
}
