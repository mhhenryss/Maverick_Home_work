using System;

namespace Maverick_Home_work.Modes
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public Logger Logger;

        public DateTime StartWorkingDate { get; set; }
        public DateTime Today { get; set; }

        public abstract decimal GetYearlyBonus();

        protected Employee(Logger logger)
        {
            Logger = logger;
        }

        protected decimal GetMonthlySalary()
        {
            var message = $"query monthly salary id:{Id}";
            Logger.Info(message);
            return SalaryRepo.Get(this.Id);
        }
    }
}