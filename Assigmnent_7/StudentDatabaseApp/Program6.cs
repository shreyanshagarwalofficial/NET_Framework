
using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program6
{
    static void Main6()
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
            DataRow row = ds.Tables["Student"].NewRow();
            Console.Write("Enter Studentid");
            row["StudentId"] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name");
            row["StudentName"] = Console.ReadLine();

            Console.Write("Enter Age");
            row["Age"] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course");
            row["Course"] = Console.ReadLine();

            ds.Tables["Student"].Rows.Add(row);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(ds, "Student");

            Console.WriteLine("Student Record Inserted Successfully!");
        }

        Console.ReadKey();
    }
}
