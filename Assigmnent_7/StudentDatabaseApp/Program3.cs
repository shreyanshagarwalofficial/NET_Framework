using System;
using Microsoft.Data.SqlClient;
class Program3
{
    static void Main3()
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;
                      Initial Catalog=CollegeDB;
                      Integrated Security=True;
                      TrustServerCertificate=True;";

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();
            string query = "UPDATE Student SET StudentName=@name, Age=@age, Course=@course WHERE StudentId=@id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", 1);
                cmd.Parameters.AddWithValue("@name", "Sachendra sir");
                cmd.Parameters.AddWithValue("@age", 22);
                cmd.Parameters.AddWithValue("@course", "MCA");
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Student Updated Successfully!");
                else
                    Console.WriteLine("Student Not Found!");
            }
        }

        Console.ReadKey();
    }
}
