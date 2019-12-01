using System;
using Maverick_Home_work.Interfaces;

namespace Maverick_Home_work.Modes
{
    public class LessThanOneYearEmployee : Employee
    {
        public LessThanOneYearEmployee(ILogger logger, ISalaryRepo salaryRepo) : base(logger, salaryRepo)
        {
        }

        public override decimal GetYearlyBonus()
        {
            _logger.Info("--get yearly bonus--");
            var salary = this.GetMonthlySalary();
            _logger.Info($"id:{Id}, his monthly salary is:{salary}");
            return Convert.ToDecimal(this.WorkingYear()) * salary;
        }

        private double WorkingYear()
        {
            _logger.Info("--get working year--");
            var year = (Today - StartWorkingDate).TotalDays / 365;
            return year > 1 ? 1 : Math.Round(year, 2);
        }
    }
}