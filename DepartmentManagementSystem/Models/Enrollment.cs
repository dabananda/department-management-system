using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagementSystem.Models
{
    public class Enrollment
    {
        public int CourseId { get; set; }
        public int DeptId { get; set; }
        //[ForeignKey("CourseId")]
        public Course Course { get; set; }
        //[ForeignKey("DeptId")]
        public Department Department { get; set; }
    }
}
