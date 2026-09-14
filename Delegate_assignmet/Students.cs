using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Students
    {
        static void Display(string Name , int Marks)
        {
            Console.WriteLine($"Student Name:" + Name + "Student Marks:" + Marks);
        }
        static void Grade(string Name, int Marks)
        {
            if (Marks > 40)
            {
                Console.WriteLine($"Student Name: " + Name + "  Grade: Passed");
            }
            else
            {
                Console.WriteLine($"Student Name: " + Name + "Grade: Failed");
            }
        }

        public delegate void StudentResult(string Name, int Marks);
        static void Main2()
        {
            Students s=new Students();
            StudentResult res = Students.Display;
            res("Surya", 56);
            StudentResult g = Students.Grade;
            g("Surya", 56);



        }
    }
}
