using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_AcessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Student student = new Student();
            Console.WriteLine("Student.Display()");
            student.Display();
            Console.WriteLine();
            Console.WriteLine("TestStudent");
            TestStudent testStudent = new TestStudent();
            testStudent.TestAccess();
        }
    }
}
