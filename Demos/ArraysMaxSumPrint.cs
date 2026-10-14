using System;
using System.Linq;

class SumOfArray
{
    static void Main(string[] args)
    {
//label1:
    Console.WriteLine("One Dimensional Array - Array , Sum and Max");
    Console.Write("Enter the size of the array: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] oneD = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Console.WriteLine("The Given array is: ");
    for(int i =0; i < n; i++)
        {
            Console.Write($"{oneD[i]}\t");
        }
    Console.WriteLine();
    Console.Write("The sum of the array is: " );
    int sum = 0;
    for(int i = 0; i < n; i++)
        {
            sum += oneD[i];
        }
    Console.WriteLine(sum);

    Console.Write("The max of the array is: " );
    int max = oneD[0];
    for(int i = 1; i < n; i++)
        {
            if(oneD[i] > max)
            {
                max = oneD[i];
            }
        }
    Console.WriteLine(max);
//Two D Array
//label2:
    Console.WriteLine("Two Dimensional Array - Array , Sum and Max");
    Console.Write("Enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the number of columns: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    int[,] twoD = new int[rows, cols];
    for(int i =0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                twoD[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

    Console.WriteLine("The Given 2D array is: ");
    for(int i =0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write($"{twoD[i,j]}\t");
            }
            Console.WriteLine();
        }
    
    Console.Write("The sum of the 2D array is: " );
    int sum2D = 0;
    for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                sum2D += twoD[i,j];
            }
        }
    Console.WriteLine(sum2D);

    Console.Write("The max of the 2D array is: " );
    int max2D = twoD[0,0];
    for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(twoD[i,j] > max2D)
                {
                    max2D = twoD[i,j];
                }
            }
        }
    Console.WriteLine(max2D);

    Console.WriteLine("Min of the 2D array is: " );
    int min2D = twoD[0,0];
    for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(twoD[i,j] < min2D)
                {
                    min2D = twoD[i,j];
                }
            }
        }
    Console.WriteLine(min2D);
//label3:
// Three D Array
    Console.WriteLine("Three Dimensional Array - Array , Sum and Max");
    Console.WriteLine("Enter the number of layers: ");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of rows: ");
    int rows3D = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int cols3D = Convert.ToInt32(Console.ReadLine());
    int[,,] threeD = new int[layers, rows3D, cols3D];
    for(int i =0; i < layers; i++)
        {
            for(int j = 0; j < rows3D; j++)
            {
                for(int k = 0; k < cols3D; k++)
                {
                    threeD[i,j,k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    Console.WriteLine("The Given 3D array is: ");
    for(int i =0; i < layers; i++)
        {
            for(int j = 0; j < rows3D; j++)
            {
                for(int k = 0; k < cols3D; k++)
                {
                    Console.Write($"{threeD[i,j,k]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    Console.Write("The sum of the 3D array is: " );
    int sum3D = 0;
    for(int i = 0; i < layers; i++)
        {
            for(int j = 0; j < rows3D; j++)
            {
                for(int k = 0; k < cols3D; k++)
                {
                    sum3D += threeD[i,j,k];
                }
            }
        }
    Console.WriteLine(sum3D);

    Console.Write("The max of the 3D array is: " );
    int max3D = threeD[0,0,0];
    for(int i = 0; i < layers; i++)
        {
            for(int j = 0; j < rows3D; j++)
            {
                for(int k = 0; k < cols3D; k++)
                {
                    if(threeD[i,j,k] > max3D)
                    {
                        max3D = threeD[i,j,k];
                    }
                }
            }
        }

    Console.WriteLine(max3D);
    Console.WriteLine("Min of the 3D array is: " );
    int min3D = threeD[0,0,0];
    for(int i = 0; i < layers; i++)
        {
            for(int j = 0; j < rows3D; j++)
            {
                for(int k = 0; k < cols3D; k++)
                {
                    if(threeD[i,j,k] < min3D)
                    {
                        min3D = threeD[i,j,k];
                    }
                }
            }
        }
    Console.WriteLine(min3D);
    }
}