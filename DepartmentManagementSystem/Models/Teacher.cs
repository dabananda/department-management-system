using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagementSystem.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image")]
        public byte[]? Image { get; set; }
        [NotMapped]
        [Display(Name = "Upload Image")]
        public IFormFile? ImageFile { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Department { get; set; }
        public string? Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joining Date")]
        public string JoiningDate { get; set; }
        [Required]
        public string Qualification { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Leaving Date")]
        public string? LeavingDate { get; set; }
        public string? Address { get; set; }
    }
}
