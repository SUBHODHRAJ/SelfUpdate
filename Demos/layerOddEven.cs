using System;

class Layers
{
    static void Main()
    {
        int[,,] evenOdd = new int[2, 4, 4];

        for (int i = 0; i < 2; i++)
        {
            int num = i;
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                evenOdd[i, j, k] = num;
                num += 2;
                }
            }
        }

        Console.WriteLine("Even and Odd numbers in a 3D array:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Layer {i + 1}:");
            for (int j = 0; j < 4; j++)
            {
                for (int k = 0; k < 4; k++)
                {
                    Console.Write($"{evenOdd[i, j, k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}