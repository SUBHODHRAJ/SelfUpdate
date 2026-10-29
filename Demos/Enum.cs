
using System;

enum CollegeDays
{
    Monday, Tuesday, Wednesday, Thursday, Friday
}

class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Yellow;

        CollegeDays today = CollegeDays.Monday;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(today + " is the " + ((int)today + 1) + " day of the week.");

            today = (CollegeDays)((int)today + 1);
        }

        Console.WriteLine("End of the week.");

        Console.ResetColor();
    }
}
