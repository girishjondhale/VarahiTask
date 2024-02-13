using VarahiTask.Repository.Interfaces;
using VarahiTask.Services.Interfaces;

namespace VarahiTask.Services
{
    public class salaryService : ISalaryService
    {
        private readonly ISalaryRepository _salaryRepository;

        public salaryService(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public decimal CalculateSalary(int workingDays)
        {
            decimal dailyWage = 100; 
            decimal salary = dailyWage * workingDays;

            _salaryRepository.SaveSalary(salary);

            return salary;
        }
    }
}
