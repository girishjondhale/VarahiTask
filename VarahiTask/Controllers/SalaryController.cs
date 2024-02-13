using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VarahiTask.Services;
using VarahiTask.Services.Interfaces;

namespace VarahiTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        // POST api/
        private readonly ISalaryService _salaryService;

        public SalaryController(ISalaryService salaryService)
        {
            _salaryService = salaryService;
        }

        [HttpPost]
        public ActionResult<decimal> CalculateSalary(int workingDays)
        {
            decimal salary = _salaryService.CalculateSalary(workingDays);

            return Ok(salary);
        }
    }
}
