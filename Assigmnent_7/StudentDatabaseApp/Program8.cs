
using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program8
{
    static void Main()
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

            Console.Write("Enter Student ID to del");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow[] rows = ds.Tables["Student"].Select("StudentId = " + id);
            if (rows.Length > 0)
            {
                rows[0].Delete();

                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Update(ds, "Student");

                Console.WriteLine("Student Record Deleted Success");
            }
            else
            {
                Console.WriteLine("NoFound!");
            }
        }

        Console.ReadKey();
    }
}
