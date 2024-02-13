using VarahiTask.Entities;
using VarahiTask.Repository.Interfaces;
using VarahiTask.Services.Interfaces;

namespace VarahiTask.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            employee.IsActive = 1;
            return repo.AddEmployee(employee);
        }
    }
}

