using System;
using UniversityLibrary;

namespace ExaminationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(
                101,
                "Rahul",
                "MCA"
            );

            Console.WriteLine("Examination Application");
            s.DisplayDetails();

            Console.ReadLine();
        }
    }
}