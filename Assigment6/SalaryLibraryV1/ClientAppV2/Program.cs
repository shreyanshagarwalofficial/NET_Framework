using System;
using SalaryLibrary;

class Program
{
    static void Main()
    {
        SalaryCalculator obj = new SalaryCalculator();

        decimal salary = 30000;

        Console.WriteLine("Salary Library Version 2.0");

        Console.WriteLine("Basic Salary: " +
            obj.CalculateBasicSalary(salary));

        Console.WriteLine("Allowances: " +
            obj.CalculateAllowances(salary));

        Console.ReadLine();
    }
}