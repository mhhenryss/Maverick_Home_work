using System;

namespace Maverick_Home_work.Modes
{
    public abstract class Employee
    {
        public DateTime StartWorkingDate { get; set; }
        public DateTime Today { get; set; }

        protected decimal GetMonthlySalary()
        {
            var message = $"query monthly salary id:{Id}";
            Info(message);
            return SalaryRepo.Get(this.Id);
        }

        public static void Info(string message)
        {
            DebugHelper.Info(message);
        }

        public abstract decimal GetYearlyBonus();

        public int Id { get; set; }
    }
}