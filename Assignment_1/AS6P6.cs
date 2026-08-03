using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    internal class AS6P6
    {
        static void Main(string[] args)
        {
            string even = "";
            string odd = "";
            Console.WriteLine("Enter a number N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                if (i % 2 == 0)
                {
                    even += i + ",";
                }
                else
                {
                    odd += i + ",";
                }
              
            }
            Console.WriteLine("even:"+ even);
            Console.WriteLine("odd:"+ odd);
            Console.WriteLine("Developed By Shreyansh Agarwal(12584200182)");
        }
    }
}