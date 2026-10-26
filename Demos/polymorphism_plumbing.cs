using System;
class Plumber
{
    public virtual void Work()
    {
        Console.WriteLine("Plumber does general work");
    }
}
class Piperepair : Plumber
{
    public override void Work()
    {
        Console.WriteLine("Repairing water pipes");
    }
}
class Taprepair : Plumber
{
    public override void Work()
    {
        Console.WriteLine("Repairing water taps");
    }
}
class Program
{
    static void Main()
    {
        Plumber plum;

        plum = new Piperepair();
        plum.Work();

        plum = new Taprepair();
        plum.Work();
    }
}