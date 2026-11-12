
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
            Console.WriteLine("5. SEARCH");
            Console.WriteLine("6. Name starts with vowels");
            Console.WriteLine("7. Name starts with vowels (SQL Query)");

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

                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                                Console.WriteLine("Record inserted successfully!");
                        }
                    }
                }
            }

            //================= UPDATE OPERATION =================
            else if (choice == 2)
            {
                Console.WriteLine("========== UPDATE OPERATION ==========");

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");

                    Console.Write("Enter student ID to update: ");
                    var id = int.Parse(Console.ReadLine() ?? string.Empty);

                    var checkQuery = "SELECT COUNT(*) FROM student WHERE id = @id";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@id", id);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            Console.WriteLine("Student ID exists!");

                            Console.Write("Enter new department: ");
                            var dept = Console.ReadLine();

                            Console.Write("Enter new marks: ");
                            var marks = int.Parse(Console.ReadLine() ?? string.Empty);

                            Console.Write("Enter new email: ");
                            var email = Console.ReadLine();

                            var query = "UPDATE student SET department = @department, marks = @marks, email = @email WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@department", dept);
                                cmd.Parameters.AddWithValue("@marks", marks);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@id", id);

                                int rows = cmd.ExecuteNonQuery();

                                if (rows > 0)
                                    Console.WriteLine("Record updated successfully!");
                                else
                                    Console.WriteLine("No changes made to the record.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Student ID not found! Update cancelled.");
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
                Console.WriteLine("========== DELETE OPERATION ==========");

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");

                    Console.Write("Enter student ID to delete: ");
                    var id = int.Parse(Console.ReadLine() ?? string.Empty);

                    var checkQuery = "SELECT COUNT(*) FROM student WHERE id = @id";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@id", id);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            var query = "DELETE FROM student WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                int rows = cmd.ExecuteNonQuery();

                                if (rows > 0)
                                    Console.WriteLine("Record deleted successfully!");
                                else
                                    Console.WriteLine("Record deletion failed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Student ID not found! Delete cancelled.");
                        }
                    }
                }
            }
            //================= SEARCH OPERATION =================
            else if (choice == 5)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");
                    Console.Write("Enter student ID to search: ");
                    var id = int.Parse(Console.ReadLine() ?? string.Empty);
                    var Searchquery = "select * from student where id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(Searchquery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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
            else if(choice == 6)
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
                            bool found = false;

                            while (red.Read())
                            {
                                string name = red["name"].ToString() ?? "";
                                if (name.Length > 0 &&(char.ToUpper(name[0]) == 'A' ||char.ToUpper(name[0]) == 'E' ||char.ToUpper(name[0]) == 'I' ||char.ToUpper(name[0]) == 'O' ||char.ToUpper(name[0]) == 'U'))
                                {
                                    found = true;
                                    Console.WriteLine($"ID: {red["id"]}, Name: {name}, Email: {red["email"]}, Department: {red["department"]}, Marks: {red["marks"]}");
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine("No student names starting with vowels found!");
                            }
                        }
                    }
                }                
            }
            
            else if(choice == 7)
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    Console.WriteLine("Attempting to connect to the database...");
                    con.Open();
                    Console.WriteLine("Connection successful!");

                    var query = "SELECT * FROM student WHERE name LIKE 'A%' OR name LIKE 'E%' OR name LIKE 'I%' OR name LIKE 'O%' OR name LIKE 'U%' ORDER BY id ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (var red = cmd.ExecuteReader())
                        {
                            while (red.Read())
                            {
                                Console.WriteLine(
                                    $"ID: {red["id"]}, Name: {red["name"]}, Email: {red["email"]}, Department: {red["department"]}, Marks: {red["marks"]}"
                                );
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice! Please select 1, 2, 3 ,4, 5, 6  or 7.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
