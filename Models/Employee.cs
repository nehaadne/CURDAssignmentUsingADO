using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CURDAssignmentUsingADO.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee name is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        [Display(Name = "Employee Salary")]
        [Range(minimum: 1, maximum: 50000)]
        public double Salary { get; set; }
    }
}


