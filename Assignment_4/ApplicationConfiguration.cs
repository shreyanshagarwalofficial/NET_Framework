using System;

namespace Assignment_3
{
    class ApplicationConfiguration
    {
        public static string Database = "GLADB";
        public static string ApplicationName = "GlaUniversityPortal";

        private ApplicationConfiguration()
        {
        }
        static void Main(string[] args)
        {
            // i cannot create an object bcause constructor is private
            // ApplicationConfiguration obj = new ApplicationConfiguration();
            Console.WriteLine("App" + ApplicationName);
            Console.WriteLine("Db" + Database);
        }
    }
}