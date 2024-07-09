using StudentWebApplication.Repositories;
using StudentWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using StudentWebApplication.Models;

namespace StudentWebApplication.Controllers
{
    public class StudentController : Controller
    {
        private IStudentServices _studentServices { get; set; }

        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        public IActionResult Index()
        {
            List<Student> students = _studentServices.GetAll();
            return View(students);
        }
        [HttpGet]
        public IActionResult addStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addStudent(int id, string name, string email, string mobileno, string address, DateTime admission_date, double fees, string status)
        {
            Student student = new Student();
            student.id = id;
            student.name = name;
            student.email = email;
            student.mobileno = mobileno;
            student.address = address;
            student.admission_date = admission_date;
            student.fees = fees;
            student.status = status;
            return Json(_studentServices.insert(student));
        }
        
        public IActionResult updateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult updateStudent(int id, string name, string email, string mobileno, string address, DateTime admission_date, double fees, string status)
        {
            Student student = new Student();
            student.id = id;
            student.name = name;
            student.email = email;
            student.mobileno = mobileno;
            student.address = address;
            student.admission_date = admission_date;
            student.fees = fees;
            student.status = status;
            return Json(_studentServices.update(student));
        }
        public IActionResult deleteStudent() 
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult deleteStudent(int id) 
        { 
            return Json(_studentServices.delete(id)); 
        }
        public IActionResult getById() 
        { 
            return View(); 
        }
        [HttpPost]
        public IActionResult getById(int id) 
        { 
            return Json(_studentServices.GetById(id)); 
        }


    }
}
