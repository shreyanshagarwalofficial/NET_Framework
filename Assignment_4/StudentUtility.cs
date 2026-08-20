using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class StudentUtility
    {
        public int marks;
        static void calc(int marks)
        {
            double percent = (marks / 500.0) * 100;
            if (percent >= 91 && percent <= 100)
            {
                Console.WriteLine("A+");
            }
            else if (percent >= 81 && percent <= 90)
            {
                Console.WriteLine("A");
            }
            else if (percent >= 71 && percent <= 80)
            {
                Console.WriteLine("B+");
            }
            else if (percent >= 61 && percent <= 70)
            {
                Console.WriteLine("B");
            }
            else if (percent >= 51 && percent <= 60)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        static void Main1(string[] args)
        {
            StudentUtility.calc(390);
        }
    }
}
