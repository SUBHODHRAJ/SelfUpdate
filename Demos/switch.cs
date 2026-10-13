using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-5): ");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}

// This program prompts the user to enter a number between 1 and 5, and then uses a switch statement to print the corresponding word for that number. If the input is not between 1 and 5, it prints "Invalid input."
// It is madatory to use break statement after each cases.