using System.ComponentModel.DataAnnotations;

namespace EmployeeManager.Models
{
    public class Employee
    {
        [Required]
        public string EmployeeID { get; set; }

        [Required]
        public string EmployeeName { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Salary must be greater than 0")]
        public double Salary { get; set; }
    }
}