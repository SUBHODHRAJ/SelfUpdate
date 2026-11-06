using System;
using System.Threading;

class MultiThread
{
    static object obj = new object();

    public void Test1()
    {
        lock (obj)
        {
            Console.WriteLine("Thread 1");
            Thread.Sleep(1000);
            Console.WriteLine("Thread 1 completed");
        }
    }

    public void Test2()
    {
        Console.WriteLine("Thread 2");
    }

    static void Main()
    {
        MultiThread mt = new MultiThread();

        Thread t1 = new Thread(mt.Test1);
        Thread t2 = new Thread(mt.Test2);

        t1.Priority = ThreadPriority.Highest;

        t1.Start();
        Thread.Sleep(500);

        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Completed");
    }
}