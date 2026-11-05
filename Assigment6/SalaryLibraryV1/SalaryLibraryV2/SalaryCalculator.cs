namespace SalaryLibrary
{
    public class SalaryCalculator
    {
        public decimal CalculateBasicSalary(decimal salary)
        {
            return salary;
        }

        public decimal CalculateAllowances(decimal salary)
        {
            decimal hra = salary * 0.20m;
            decimal da = salary * 0.10m;

            return hra + da;
        }
    }
}