using System;

namespace TaxLibrary
{
    public class TaxCalculator
    {
        public decimal CalculateOldRegimeTax(decimal income)
        {
            decimal tax = 0;

            if (income <= 250000)
                tax = 0;
            else if (income <= 500000)
                tax = (income - 250000) * 0.05m;
            else if (income <= 1000000)
                tax = 12500 + (income - 500000) * 0.20m;
            else
                tax = 112500 + (income - 1000000) * 0.30m;

            return tax * 1.04m;
        }
        public decimal CalculateNewRegimeTax(decimal income)
        {
            decimal tax = 0;

            if (income <= 400000)
                tax = 0;
            else if (income <= 800000)
                tax = (income - 400000) * 0.05m;
            else if (income <= 1200000)
                tax = 20000 + (income - 800000) * 0.10m;
            else if (income <= 1600000)
                tax = 60000 + (income - 1200000) * 0.15m;
            else if (income <= 2000000)
                tax = 120000 + (income - 1600000) * 0.20m;
            else if (income <= 2400000)
                tax = 200000 + (income - 2000000) * 0.25m;
            else
                tax = 300000 + (income - 2400000) * 0.30m;

            return tax;
        }
    }
}