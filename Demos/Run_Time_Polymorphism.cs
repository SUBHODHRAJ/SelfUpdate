using System;

class Rtp
{
    static void Main(string[] args)
    {
        subhodh s = new subhodh();
        s.Teaching();

        subhodh d = new Department();
        d.Teaching();

        subhodh p = new Placement();
        p.Teaching();

        subhodh a = new Admin();
        a.Teaching();
    }
}

class subhodh
{
    public virtual void Teaching()
    {
        Console.WriteLine("subhodh Teaches in class.");
    }
}

class Department : subhodh
{
    public override void Teaching()
    {
        Console.WriteLine("Department subhodh Teaches in  respective department class.");
    }
}

class Placement : subhodh
{
    public override void Teaching()
    {
        Console.WriteLine("Provide Placement training");
    }
}

class Admin : subhodh
{
    public sealed override void Teaching()
    {
        Console.WriteLine("Admin subhodh Teaches in Admin class.");
    }
}