using DepartmentManagementSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentManagementSystem.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EnrollmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            ViewBag.Departments = departments;
            var courses = _context.Courses.ToList();
            ViewBag.Courses = courses;
            return View();
        }
    }
}
