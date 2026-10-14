using System;

class Factorial
{
    static void Main()
    {
        Console.WriteLine("Factorial Program");
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }


        Console.WriteLine("Factorial of " + num + " is: " + fact);
    }
}