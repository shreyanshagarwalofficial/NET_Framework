using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Display(int x, int y)
        {
            int c = x + y;
            Console.WriteLine(c);
        }
        public delegate void sum(int x , int y);
        static void Main1(string[] args)
        {
            Program p=new Program();
            sum ms = Program.Display;
            ms(10, 20);
        }
    }
}
