using Employees_API.Enums;
using System.ComponentModel.DataAnnotations;

namespace Employees_API.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DepartmentEnum Department { get; set; }
        public bool Active { get; set; }
        public PeriodEnum Period { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DateModified { get; set; } = DateTime.Now.ToLocalTime();
    }
}
