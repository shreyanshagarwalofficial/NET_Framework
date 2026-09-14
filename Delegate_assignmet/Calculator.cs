using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Calculator
    {
        static void Add(int x , int y)
        {
            Console.WriteLine($"Add:{ x + y}");
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine($"Subtrat:{x - y}");
        }
        static void Mult(int x, int y)
        {
            Console.WriteLine($"Mutiply:{x * y}");
        }
        static void Division(int x, int y)
        {
            Console.WriteLine($"Division:{x / y}");
        }
        public delegate void Calculators(int x, int y);
        static void Main4()
        {
            Calculator c=new Calculator();
            Calculators s = Calculator.Add;
            s += Calculator.Sub ;
            Calculators m = Calculator.Mult;
            m+= Calculator.Division;
            s(11, 15);
            m(10, 9);


        }
    }
}
