
using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program5
{
    static void Main5()
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;
                      Initial Catalog=CollegeDB;
                      Integrated Security=True;
                      TrustServerCertificate=True;";

        using (SqlConnection con = new SqlConnection(cs))
        {
            string query = "SELECT * FROM Student";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            Console.WriteLine("Student Records:");
            foreach (DataRow row in ds.Tables["Student"].Rows)
            {
                Console.WriteLine(
                    row["StudentId"] + " " +
                    row["StudentName"] + " " +
                    row["Age"] + " " +
                    row["Course"]);
            }
        }

        Console.ReadKey();
    }
}
