
using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main1(string[] args)
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
                Console.WriteLine();
                string query = "SELECT * FROM Student";
                using (SqlCommand cmd =
                       new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("STUDENT RECORDS");
                        while (reader.Read())
                        {
                            Console.WriteLine(
                                "Student ID" + reader["StudentId"]);

                            Console.WriteLine(
                                "Student Name" + reader["StudentName"]);

                            Console.WriteLine(
                                "Age" + reader["Age"]);

                            Console.WriteLine(
                                "Course" + reader["Course"]);
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
        Console.ReadKey();
    }
}
