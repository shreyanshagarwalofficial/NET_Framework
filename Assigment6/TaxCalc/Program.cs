using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxLibrary;

namespace TaxCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator ob1 = new TaxCalculator();
            decimal oldRegimeTax = ob1.CalculateOldRegimeTax(800000);
            decimal newRegimeTax = ob1.CalculateNewRegimeTax(1400000);

            Console.WriteLine($"Old regime tax:{oldRegimeTax}", oldRegimeTax);
            Console.WriteLine($"New regime tax:{newRegimeTax} ", newRegimeTax);

        }
    }
}
