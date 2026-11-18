
using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program7
{
    static void Main7()
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

            Console.Write("Enter Student ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow[] rows = ds.Tables["Student"].Select("StudentId = " + id);

            if (rows.Length > 0)
            {
                Console.Write("Enter New Name");
                rows[0]["StudentName"] = Console.ReadLine();

                Console.Write("Enter New Age");
                rows[0]["Age"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Course ");
                rows[0]["Course"] = Console.ReadLine();

                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                da.Update(ds, "Student");

                Console.WriteLine("Student Record UpdateSuccess");
            }
            else
            {
                Console.WriteLine("No Found");
            }
        }

        Console.ReadKey();
    }
}
