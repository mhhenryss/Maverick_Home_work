using System;

namespace Maverick_Home_work.Modes
{
    public abstract class Employee
    {
        private Logger _logger = new Logger();
        public int Id { get; set; }
        public Logger Logger
        {
            get { return _logger; }
        }

        public DateTime StartWorkingDate { get; set; }
        public DateTime Today { get; set; }

        public abstract decimal GetYearlyBonus();

        protected decimal GetMonthlySalary()
        {
            var message = $"query monthly salary id:{Id}";
            Logger.Info(message);
            return SalaryRepo.Get(this.Id);
        }
    }

    public class Logger
    {
        public void Info(string message)
        {
            DebugHelper.Info(message);
        }
    }
}