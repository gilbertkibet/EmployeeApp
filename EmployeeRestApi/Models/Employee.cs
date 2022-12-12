using System.ComponentModel.DataAnnotations;

namespace EmployeeRestApi.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long Phone { get; set; }
        [Required]
        public long Salary { get; set; }
        [Required]
        public long Department { get; set; }

    }
}
