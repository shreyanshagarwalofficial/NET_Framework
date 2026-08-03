using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    internal class ASP3
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (Num == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            else 
            { 
                Console.WriteLine("Negative Number");
            }
            Console.WriteLine("Developed By Shreyansh Agarwal(12584200182)");
        }
    }
}
