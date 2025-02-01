using DepartmentManagementSystem.Data;
using DepartmentManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TeacherController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Teachers List
        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teachers.ToList();
            return View(teachers);
        }

        // GET: Create New Teacher Form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Create New Teacher
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                if (teacher.ImageFile != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        teacher.ImageFile.CopyTo(memoryStream);
                        teacher.Image = memoryStream.ToArray();
                    }
                }
                _context.Teachers.Add(teacher);
                _context.SaveChanges();
                TempData["Message"] = "Teacher added successfully!";
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // GET: Edit Teacher Form
        public IActionResult Edit(int id)
        {
            Teacher teacher = _context.Teachers.Find(id);
            return View(teacher);
        }

        // POST: Edit Teacher
        [HttpPost]
        public IActionResult Edit(Teacher teacher)
        {
            Teacher existingTeacher = _context.Teachers.Find(teacher.Id);
            if (existingTeacher != null)
            {
                existingTeacher.Name = teacher.Name;
                existingTeacher.Gender = teacher.Gender;
                existingTeacher.Designation = teacher.Designation;
                existingTeacher.Department = teacher.Department;
                existingTeacher.Email = teacher.Email;
                existingTeacher.Phone = teacher.Phone;
                existingTeacher.JoiningDate = teacher.JoiningDate;
                existingTeacher.Qualification = teacher.Qualification;
                existingTeacher.LeavingDate = teacher.LeavingDate;
                existingTeacher.Address = teacher.Address;

                if (teacher.ImageFile != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        teacher.ImageFile.CopyTo(memoryStream);
                        existingTeacher.Image = memoryStream.ToArray();
                    }
                }

                _context.Update(existingTeacher);
                _context.SaveChanges();
                TempData["Message"] = "Teacher updated successfully!";
                return RedirectToAction("Index");
            }
            return View(teacher);
        }

        // Post: Delete Teacher
        
        public IActionResult Delete(int id)
        {
            Teacher teacher = _context.Teachers.Find(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
                TempData["Message"] = "Teacher deleted successfully!";
            }
            return RedirectToAction("Index");
        }
    }
}
