using VarahiTask.Data;
using VarahiTask.Entities;
using VarahiTask.Repository.Interfaces;

namespace VarahiTask.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddEmployee(Employee employee)
        {
            int result = 0;
            _context.Employees.Add(employee);
            result = _context.SaveChanges();
            return result;
        }
    }
}
