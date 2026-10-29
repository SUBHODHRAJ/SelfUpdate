
using System;
record class School(string? SchoolName, int NoOfStudentsinSchool, string? Course);
record class College(string? CollegeName, int NoOfStudents, string? Location)
    : School(SchoolName: CollegeName, NoOfStudentsinSchool: NoOfStudents, Course: Location);
class Program
{
    static void Main(string[] args)
    {
        College record2 = new College("XYZ College", 500, "New York")
        {
            SchoolName = "SDA",
            NoOfStudentsinSchool = 32,
            Course = "HR"
        };
        Console.WriteLine(record2);
    }
}
