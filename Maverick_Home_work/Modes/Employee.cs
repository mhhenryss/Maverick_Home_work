using System;
using Maverick_Home_work.Interfaces;

namespace Maverick_Home_work.Modes
{
    public abstract class Employee
    {
        public int Id { get; set; }
        protected ILogger _logger;
        private readonly ISalaryRepo _salaryRepo;

        public DateTime StartWorkingDate { get; set; }
        public DateTime Today { get; set; }

        public abstract decimal GetYearlyBonus();

        protected Employee(ILogger logger, ISalaryRepo salaryRepo)
        {
            _logger = logger;
            _salaryRepo = salaryRepo;
        }

        protected decimal GetMonthlySalary()
        {
            var message = $"query monthly salary id:{Id}";
            _logger.Info(message);
            return _salaryRepo.Get(this.Id);
        }
    }
}