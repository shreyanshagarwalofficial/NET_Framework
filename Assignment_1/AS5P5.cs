using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    internal class AS5P5
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Enter a First Number ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a First Number ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1:Addition ");
            Console.WriteLine("2: Subtraction ");
            Console.WriteLine("3: Multiplication ");
            Console.WriteLine("4: Division ");
            int op= Convert.ToInt32(Console.ReadLine());
            switch(op) {

            case 1: 
                    int add = Num1 + Num2;
                    Console.WriteLine(add);
                    break;
            case 2:
                    int sub=Num1 - Num2;
                    Console.WriteLine(sub);
                    break;
            case 3:
                    int mult = Num1 * Num2;
                    Console.WriteLine(mult);
                    break;
            case 4:
                    int div = Num1 / Num2;
                    Console.WriteLine(div);
                    break;
            default:
                    Console.WriteLine("default ");
                    break;
                }
            Console.WriteLine("Developed By Shreyansh Agarwal(12584200182)");
        }
    }
}
