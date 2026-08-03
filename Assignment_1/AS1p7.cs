using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    internal class AS1p7
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter a number N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                 fact*= i;

            }
            Console.WriteLine(fact);
            Console.WriteLine("Developed By Shreyansh Agarwal(12584200182)");
        }
    }
}
