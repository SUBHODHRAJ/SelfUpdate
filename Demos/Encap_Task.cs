using System;

class Student
{
    private string? Studentname;
    private int mark;

    public string? Name
    {
        get { return Studentname; }
        set { Studentname = value; }
    }

    public int Mark
    {
        get { return mark; }
        set
        {
            if (value >= 0 && value <= 100)
                mark = value;
            else
                mark = 0;
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        Console.Write("Enter Student Name: ");
        String? name_ = Console.ReadLine();
        s.Name = name_;
        Console.Write("Enter Student Mark: ");
        int mark_ = Convert.ToInt32(Console.ReadLine());
        s.Mark = mark_;

        Console.WriteLine("Student Name: " + s.Name);
        Console.WriteLine("Student Mark: " + s.Mark);

        Console.Write("Enter Updated Mark: ");
        int Update_mark = Convert.ToInt32(Console.ReadLine());
        s.Mark = Update_mark;
        Console.WriteLine("Updated Mark: " + s.Mark);
    }
}