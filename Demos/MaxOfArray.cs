using System;

class OneDmatrix
{
    static void Main()
    {
       /* int[] arr = {2,3,4,5,6,78,97,75,34,23,12,11};
        int n = arr.Length;
        int max = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("The largest element in the array is : " + max);
    */

    int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        int max = arr[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }
        Console.WriteLine("The largest element in the array is : " + max);
        
    }
}