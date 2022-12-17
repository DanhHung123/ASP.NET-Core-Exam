using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud.Models
{
    public class Employee
    {
        [Required]
        public int EmployeeID { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string Department { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
    }
}
