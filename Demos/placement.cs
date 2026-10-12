using System;

class Placement
{
    static void Main()
    {
        Console.WriteLine("Enter Your Current Year");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 4)
        {
            Console.WriteLine("Enter No of Backlog");
            int backlog = Convert.ToInt32(Console.ReadLine());
            if(backlog == 0)
            {   
                Console.WriteLine("Enter Your CGPA");
                float cgpa = float.Parse(Console.ReadLine());
                if(cgpa >= 7.5f)
                {
                    Console.WriteLine("You are Eligible for Placement");
                }
                else
                {
                    Console.WriteLine("You are Not Eligible for Placement");
                }
            }
            else
            {
                Console.WriteLine("You are Not Eligible for Placement");
            }
        }else
        {
            Console.WriteLine("You are Not Eligible for Placement");
        }
    }
}