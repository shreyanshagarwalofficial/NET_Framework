
using System;
using Microsoft.Data.SqlClient;

class Program4
{
    static void Main4()
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;
                      Initial Catalog=CollegeDB;
                      Integrated Security=True;
                      TrustServerCertificate=True;";
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();
            Console.Write("Enter Student ID to delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            string query = "DELETE FROM Student WHERE StudentId = @id";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("Student Record Deleted Successfully!");
                else
                    Console.WriteLine("Student ID Not Found!");
            }
        }
        Console.ReadKey();
    }
}
