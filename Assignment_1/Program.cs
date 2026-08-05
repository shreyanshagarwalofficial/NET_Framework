using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int No1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int No2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of Two Numbers is :" + (No1+No2));
            Console.WriteLine("DIIFERENCE:"+(No1-No2));
            Console.WriteLine("PRODUCT:"+(No1*No2));
            Console.WriteLine("DIVIDE:"+(No1/No2));
            Console.WriteLine("REM:" + (No1 % No2));
        }
    }
}
