using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class EmployeePayroll
    {
        private int employeeId;
        private string name;
        private double basicSalary;
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double BasicSalary
        {
            get
            {
                return basicSalary;
            }
            set
            {
                basicSalary = value;
            }
        }
        public double HRA
        {
            get
            {
                return basicSalary * 20 / 100;
            }
        }
        public double DA
        {
            get
            {
                return basicSalary * 10 / 100;
            }
        }
        public double GrossSalary
        {
            get
            {
                return basicSalary + HRA + DA;
            }
        }
        public double Tax
        {
            get
            {
                if (GrossSalary > 100000)
                    return GrossSalary * 20 / 100;
                else if (GrossSalary > 50000)
                    return GrossSalary * 10 / 100;
                else
                    return GrossSalary * 5 / 100;
            }
        }
        public double NetSalary
        {
            get
            {
                return GrossSalary - Tax;
            }
        }
    }
    internal class Program7
    {
        static void Main(string[] args)
        {
            EmployeePayroll employee = new EmployeePayroll();
            employee.EmployeeId = 101;
            employee.Name = "Shreyansh";
            employee.BasicSalary = 60000;
            Console.WriteLine("EmployeeSalary Statement");
            Console.WriteLine("EmployeeID: " + employee.EmployeeId);
            Console.WriteLine("Employeename:" + employee.Name);
            Console.WriteLine("Basic salary" + employee.BasicSalary);
            Console.WriteLine("HRA" + employee.HRA);
            Console.WriteLine("DA" + employee.DA);
            Console.WriteLine("Grosssalary" + employee.GrossSalary);
            Console.WriteLine("Tax" + employee.Tax);
            Console.WriteLine("Netsalary" + employee.NetSalary);
        }
    }
}