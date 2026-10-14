using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string or number: ");
        string a = Console.ReadLine() ?? "";
        if (int.TryParse(a, out int num))
        {
            int a = num;
            int aa = 0;
            while (num > 0)
            {
                int digit = num % 10;
                aa = aa * 10 + digit;
                num /= 10;
            }
            if (a == aa)
                Console.WriteLine("The number is a palindrome.");
            else
                Console.WriteLine("The number is not a palindrome.");
        }
        else
        {
            int l = 0;
            int r = a.Length - 1;
            while (l < r)
            {
                if (a[l] != a[r])
                {
                    Console.WriteLine("The string is not a palindrome.");
                    return;
                }
                l++;
                r--;
            }
            Console.WriteLine("The string is a palindrome.");
        }
    }
}
