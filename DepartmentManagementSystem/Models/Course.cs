using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string? CourseTitle { get; set; }
        public string? CourseCode { get; set; }
        public decimal CreditHours { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
