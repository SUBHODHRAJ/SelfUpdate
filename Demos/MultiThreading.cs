using System;
using System.Threading;

class MultiThread
{
    public void Testing1()
    {
        Console.WriteLine("Testing1");
    }

    public void Testing2()
    {
        Console.WriteLine("Testing2");
    }

    public void Testing3()
    {
        Console.WriteLine("Testing3");
    }

    public static void Main(string[] args)
    {
        MultiThread mt = new MultiThread();

        Thread t1 = new Thread(mt.Testing1);
        Thread t2 = new Thread(mt.Testing2);
        Thread t3 = new Thread(mt.Testing3);
        Console.WriteLine("Starting threads...");
        t1.Start();
        Thread.Sleep(1000);
        Console.WriteLine("Starting thread 2...");
        t2.Start();

        Thread.Sleep(1000);
        Console.WriteLine("Starting thread 3...");
        t3.Start();
        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All threads completed!");
    }
}