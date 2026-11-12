
using System;
using MySql.Data.MySqlClient;

class AdoDotNet
{
    static void Main(string[] args)
    {
        var connectionString = "Server=localhost;Database=adodb;User=root;Password=1234;";

        try
        {
            Console.WriteLine("========== STUDENT MANAGEMENT ==========");
            Console.WriteLine("1. INSERT");
            Console.WriteLine("2. UPDATE");
            Console.WriteLine("3. READ");
            Console.WriteLine("4. DELETE");

            Console.Write("Enter your choice: ");
            var choice = int.Parse(Console.ReadLine() ?? string.Empty);

            //================= INSERT OPERATION =================
            if (choice == 1)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");

                    Console.Write("Enter the number of records to insert: ");
                    var n = int.Parse(Console.ReadLine() ?? string.Empty);

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter name: ");
                        var name = Console.ReadLine();

                        Console.Write("Enter email: ");
                        var email = Console.ReadLine();

                        Console.Write("Enter department: ");
                        var dept = Console.ReadLine();

                        Console.Write("Enter marks: ");
                        var marks = int.Parse(Console.ReadLine() ?? string.Empty);

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
                }
            }

            //================= UPDATE OPERATION =================
            else if (choice == 2)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");

                    Console.Write("Enter student email to update: ");
                    var email = Console.ReadLine();

                    Console.Write("Enter new department: ");
                    var dept = Console.ReadLine();

                    Console.Write("Enter new marks: ");
                    var marks = int.Parse(Console.ReadLine() ?? string.Empty);

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
            }

            //================= READ OPERATION =================
            else if (choice == 3)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");

                    var query = "SELECT * FROM student ORDER BY id ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (var red = cmd.ExecuteReader())
                        {
                            while (red.Read())
                            {
                               Console.WriteLine($"ID: {red["id"]}, Name: {red["name"]}, Email: {red["email"]}, Department: {red["department"]}, Marks: {red["marks"]}");
                            }
                        }
                    }
                }
            }

            //================= DELETE OPERATION =================
            else if (choice == 4)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");

                    Console.Write("Enter student email to delete: ");
                    var email = Console.ReadLine();

                    var query = "DELETE FROM student WHERE email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            Console.WriteLine("Record deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student record not found!");
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("Invalid choice! Please select 1, 2, 3 or 4.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
