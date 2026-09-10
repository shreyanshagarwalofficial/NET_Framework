using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class EmployeeBonus
    {
        private string name;
        private double basicSalary;
        private int experience;
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

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        public double Bonus
        {
            get
            {
                if (experience >= 10)
                    return basicSalary * 20 / 100;
                else if (experience >= 5)
                    return basicSalary * 10 / 100;
                else
                    return basicSalary * 5 / 100;
            }
        }
    }
    internal class Program3
    {
        static void Main(string[] args)
        {
            EmployeeBonus emp = new EmployeeBonus();
            emp.Name = "Shreyansh";
            emp.BasicSalary = 90000000;
            emp.Experience = 2;
            Console.WriteLine("Employee Name" + emp.Name);
            Console.WriteLine("Basic Salary" + emp.BasicSalary);
            Console.WriteLine("Experience" + emp.Experience);
            Console.WriteLine("Bonus" + emp.Bonus);
        }
    }
}