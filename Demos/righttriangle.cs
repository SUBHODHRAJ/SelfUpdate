using System;

class Righttriangle
{
    static void Main()
    {
        Console.Write("Enter the number of rows :");
        int row = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= row; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"+" ");
            }
            Console.WriteLine();
        }
    }
}