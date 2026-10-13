using System;

class SumOfN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
    /*    int n = Convert.ToInt32(Console.ReadLine());

        
        int i = 0;
        int sum = 0;
        while (i<(n+1))
        {
            sum +=i;
            Console.WriteLine("Current sum: " + sum);
            i++;
        }
        Console.WriteLine("Sums of N number " + sum);*/

/*        while (true)
        {
            int sum = n*(n+1)/2;
            Console.WriteLine("Sum of N numbers is: " + sum);
            break;
        }
 */ 
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while(n > 0)
        {
            int t = n%10;
            sum += t;
            n /= 10;
        }
        Console.WriteLine("Sum of digits is: " + sum);
    }
}