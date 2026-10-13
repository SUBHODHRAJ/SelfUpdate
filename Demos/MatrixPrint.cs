using System;

class PrintMatrix
{
    static void Main()
    {
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = i * 4 + j + 1;
            }
        }
        Console.WriteLine("Matrix:");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
