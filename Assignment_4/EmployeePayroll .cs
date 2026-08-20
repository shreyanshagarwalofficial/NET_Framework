using System;

namespace Assignment_3
{
    internal sealed class EmployeePayroll
    {
        private string employeeName;
        private double basicSalary;
        private double taxRate;
        public EmployeePayroll(string name, double salary, double taxRate)
        {
            employeeName = name;
            basicSalary = salary;
            this.taxRate = taxRate;
        }
        public double CalculateTax()
        {
            return basicSalary * taxRate / 100;
        }
        public double CalculateNetSalary()
        {
            return basicSalary - CalculateTax();
        }

        public void DisplayPayroll()
        {
            Console.WriteLine("Employee: " + employeeName);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Tax: " + CalculateTax());
            Console.WriteLine("Net Salary: " + CalculateNetSalary());
        }
        static void Main2(string[] args)
        {
            EmployeePayroll emp = new EmployeePayroll("Surya", 50000, 10);
            emp.DisplayPayroll();

            Console.ReadLine();
        }
    }
}
