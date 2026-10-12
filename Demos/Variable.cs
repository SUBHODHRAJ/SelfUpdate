using System;

namespace Variable
{
    class Subhodh
    {
        static void Main()
        {
        //   int n;
            Console.Write("Enter Your CGPA :");
        //  n = Convert.ToInt32(Console.ReadLine());
            if ((Convert.ToInt32(Console.ReadLine())) >= 85) Console.WriteLine("Eligible");
            else Console.WriteLine("Not Eligible");
            Console.Write("Enter Your Marks in 10th :");
            Console.WriteLine((Convert.ToInt32(Console.ReadLine())) >= 85 ? "Placement available" : "Placement not available");
        
        }   
    }
}