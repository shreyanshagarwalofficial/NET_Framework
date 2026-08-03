using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    internal class AS1P4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter a Marks btw 1-100");
            int Marks = Convert.ToInt32(Console.ReadLine());
    
            if (Marks>=91 && Marks<=100 )
            {
                Console.WriteLine("Grade:O");
            }
            else if (Marks >= 81 && Marks <= 90)
            {
                Console.WriteLine("Grade:A+");
            }
            else if (Marks >= 71 && Marks <= 80)
            {
                Console.WriteLine("Grade:A");
            }
            else if (Marks >= 61 && Marks <= 70)
            {
                Console.WriteLine("Grade:B+");
            }
            else if (Marks >= 51 && Marks <= 60)
            {
                Console.WriteLine("Grade:B");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine("Developed By Shreyansh Agarwal(12584200182)");
        }
    }
}
