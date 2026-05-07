using Microsoft.AspNetCore.Mvc;

namespace SchoolApp_MVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
