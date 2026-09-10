using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class TemperatureConversion
    {
        private double celsius;

        public double Celsius
        {
            get
            {
                return celsius;
            }
            set
            {
                if (value >= -273.15)
                    celsius = value;
            }
        }
        public double Fahrenheit
        {
            get
            {
                return (celsius * 9 / 5) + 32;
            }
        }
    }
    internal class Program4
    {
        static void Main(string[] args)
        {
            TemperatureConversion t= new TemperatureConversion();

            t.Celsius = 25;

            Console.WriteLine("Celsius" + t.Celsius);
            Console.WriteLine("Fahrenheit" + t.Fahrenheit);
        }
    }
}