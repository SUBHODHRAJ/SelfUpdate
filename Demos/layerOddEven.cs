using System;

class Layers
{
    static void Main()
    {
        int[,,] evenOdd = new int[4, 4, 4];
        for (int i = 0; i < evenOdd.GetLength(0); i++)
        {
            int num = i%2;
            for (int j = 0; j < evenOdd.GetLength(1); j++)
            {
                for (int k = 0; k < evenOdd.GetLength(2); k++)
                {
                evenOdd[i, j, k] = num;
                num += 2;
                }
            }
        }
        Console.WriteLine("Even and Odd numbers in a 3D array:");
        for (int i = 0; i < evenOdd.GetLength(0); i++)
        {
            Console.WriteLine("Layer " + (i + 1) + ":");
            for (int j = 0; j < evenOdd.GetLength(1); j++)
            {
                for (int k = 0; k < evenOdd.GetLength(2); k++)
                {
                    Console.Write($"{evenOdd[i, j, k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
