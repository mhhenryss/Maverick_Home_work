using System;

namespace Maverick_Home_work.Modes
{
    public class LessThanOneYearEmployee : Employee
    {
        public LessThanOneYearEmployee(ILogger logger) : base(logger)
        {
        }

        public override decimal GetYearlyBonus()
        {
            Logger.Info("--get yearly bonus--");
            var salary = this.GetMonthlySalary();
            Logger.Info($"id:{Id}, his monthly salary is:{salary}");
            return Convert.ToDecimal(this.WorkingYear()) * salary;
        }

        private double WorkingYear()
        {
            Logger.Info("--get working year--");
            var year = (Today - StartWorkingDate).TotalDays / 365;
            return year > 1 ? 1 : Math.Round(year, 2);
        }
    }
}