using System;
using SalaryLibrary;

class Program
{
    static void Main()
    {
        SalaryCalculator obj = new SalaryCalculator();

        decimal salary = 30000;

        Console.WriteLine("Salary Library Version 1.0");
        Console.WriteLine("Basic Salary: " +
            obj.CalculateBasicSalary(salary));

        Console.ReadLine();
    }
}