using System;
using UniversityLibrary;

namespace AttendanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(
                102,
                "Amit",
                "BCA"
            );

            Console.WriteLine("Attendance Application");
            s.DisplayDetails();

            Console.ReadLine();
        }
    }
}