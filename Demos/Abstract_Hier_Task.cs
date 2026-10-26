using System;

abstract class Staff
{
    public abstract void TeachingNotes();
    public abstract void Work();
    public abstract void AttendMeeting();
}

class Teacher : Staff
{
    public override void TeachingNotes()
    {
        Console.WriteLine("Teachers prepare and deliver lectures.");
    }
    public override void Work()
    {
        Console.WriteLine("Teachers grade assignments and provide feedback.");
    }
    public override void AttendMeeting()
    {
        Console.WriteLine("Teachers attend staff meetings");
    }
}
class Student : Staff
{
    public override void TeachingNotes()
    {
        Console.WriteLine("Students take notes during lectures.");
    }
    public override void Work()
    {
        Console.WriteLine("Students work on assignments and projects.");
    }
    public override void AttendMeeting()
    {
        Console.WriteLine("Students attend class meetings.");
    }
}

class Principal : Staff
{
    public override void TeachingNotes()
    {
        Console.WriteLine("Principal oversees the teaching process.");
    }
    public override void Work()
    {
        Console.WriteLine("Principal manages school operations and staff.");
    }
    public override void AttendMeeting()
    {
        Console.WriteLine("Principal attends administrative meetings and conferences.");
    }
}

class Task
{
    static void Main()
    {
        Staff p = new Principal();
        Staff t = new Teacher();
        Staff s = new Student();

        Console.WriteLine("Principal's Responsibilities:");
        p.TeachingNotes();
        p.Work();
        p.AttendMeeting();

        Console.WriteLine();

        Console.WriteLine("Teacher's Responsibilities:");
        t.TeachingNotes();
        t.Work();
        t.AttendMeeting();

        Console.WriteLine();

        Console.WriteLine("Student's Responsibilities:");
        s.TeachingNotes();
        s.Work();
        s.AttendMeeting();
    }
}
