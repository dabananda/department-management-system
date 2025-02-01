using System.ComponentModel.DataAnnotations;

namespace DepartmentManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Department Name")] 
        public string? DepartmentName { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Display(Name = "Established Date")]
        public string? EstablishedDate { get; set; }
        [Display(Name = "Phone")]
        public string? DepartmentPhone { get; set; }
        [Display(Name = "Department Email")]
        public string? DepartmentEmail { get; set; }
        [Display(Name = "Website")]
        public string? DepartmentWebsite { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
