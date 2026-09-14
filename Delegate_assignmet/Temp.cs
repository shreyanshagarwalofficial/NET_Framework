using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Temp
    {
        static void Ctof(float c)
        {
            float f = (c * 9 / 5) + 32;
            Console.WriteLine("Celsius to Fahrenheit: " + f);
        }
        static void Ctok(float c)
        {
            double k = c + 273.15;
            Console.WriteLine("Celsius to Fahrenheit: " + k);
        }
        public delegate void Temperature(float c);
        static void Main()
        {
            Temp t=new Temp();
            Temperature r = Temp.Ctof;
            Temperature s = Temp.Ctok;
            r(25);
            s(30);
        }
    }
}
