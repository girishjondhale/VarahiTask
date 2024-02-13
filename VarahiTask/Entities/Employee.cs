namespace VarahiTask.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public string? Department { get; set; }
        public int WorkingDays { get; set; }
        public int IsActive { get; set;}
    }
}
