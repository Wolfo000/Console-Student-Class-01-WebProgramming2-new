using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using SchoolApp_MVC.Services;

namespace SchoolApp_MVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;

            Student s = _studentService.FindStudentByIdAsync(1).GetAwaiter().GetResult();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentsList(int id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
