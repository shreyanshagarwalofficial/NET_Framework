using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    internal class Lecture1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter Student Name:");
            String Name = Console.ReadLine();
            Console.WriteLine("Enter Roll No:");
            int RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Your Marks");
            int Marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Roll No {RollNo} Student Name is {Name} Total Marks is {Marks}");
        }
    }
}
