using System;
using Microsoft.Data.SqlClient;
class Program2
{
    static void Main2(string[] args)
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;
              Initial Catalog=CollegeDB;
              Integrated Security=True;
              TrustServerCertificate=True;";
        try
        {
            using (SqlConnection con =
                   new SqlConnection(connectionString))
            {
                con.Open();
                Console.WriteLine("Database Connected Successfully!");

                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                string course = Console.ReadLine() ?? "";
                string query =
                    "INSERT INTO Student" +
                    "(StudentId, StudentName, Age, Course) " +
                    "VALUES (@id, @name, @age, @course)";
                using (SqlCommand cmd =
                       new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@course", course);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        Console.WriteLine(
                            "StudentRecord Inserted Success");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        Console.ReadKey();
    }
}
