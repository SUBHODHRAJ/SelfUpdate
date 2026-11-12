
using System;
using MySql.Data.MySqlClient;

class AdoDotNet
{
    static void Main(string[] args)
    {
        var connectionString = "Server=localhost;Database=adodb;User=root;Password=1234;";

        try
        {
            /*using (MySqlConnection con = new MySqlConnection(connectionString))
            {

                 ================= INSERT OPERATION =================

                Console.WriteLine("Attempting to connect to the database");
                con.Open();
                Console.WriteLine("Connection successful!");

                Console.WriteLine("Enter the number of records to insert:");
                var n = int.Parse(Console.ReadLine());

                var name = "";
                var email = "";
                var dept = "";
                var marks = 100;

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Enter name : ");
                    name = Console.ReadLine();

                    Console.Write("Enter email : ");
                    email = Console.ReadLine();

                    Console.Write("Enter department : ");
                    dept = Console.ReadLine();

                    var query = "INSERT INTO student(name, email, department, marks) VALUES(@name, @email, @department, @marks)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@department", dept);
                        cmd.Parameters.AddWithValue("@marks", marks);

                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Record inserted successfully!");
                    }
                }
             }*/

            /* using (MySqlConnection con = new MySqlConnection(connectionString))
             {
                 UPDATE OPERATION

                 Console.WriteLine("Attempting to connect to the database");
                 con.Open();
                 Console.WriteLine("Connection successful!");

                 Console.Write("Enter student email to update: ");
                 var email = Console.ReadLine();

                 Console.Write("Enter new department: ");
                 var dept = Console.ReadLine();

                 Console.Write("Enter new marks: ");
                 var marks = int.Parse(Console.ReadLine());

                 var query = "UPDATE student SET department = @department, marks = @marks WHERE email = @email";

                 using (MySqlCommand cmd = new MySqlCommand(query, con))
                 {
                     cmd.Parameters.AddWithValue("@department", dept);
                     cmd.Parameters.AddWithValue("@marks", marks);
                     cmd.Parameters.AddWithValue("@email", email);

                     int rows = cmd.ExecuteNonQuery();

                     if (rows > 0)
                     {
                         Console.WriteLine("Record updated successfully!");
                     }
                     else
                     {
                         Console.WriteLine("Student record not found!");
                     }
                 } 
                }
            */


            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                //Read Operation
                Console.WriteLine("Attempting to connect to the database");
                con.Open();
                Console.WriteLine("Connection successful!");
                var rquery = "SELECT * FROM student";
                using (MySqlCommand cmd = new MySqlCommand(rquery, con))
                {
                    using var red = cmd.ExecuteReader();
                    {
                        while (red.Read())
                        {
                            Console.WriteLine($"ID: {red["id"]}, Name: {red["name"]}, Email: {red["email"]}, Department: {red["department"]}, Marks: {red["marks"]}");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
