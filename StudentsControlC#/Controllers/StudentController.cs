using Microsoft.AspNetCore.Mvc;

namespace StudentsControlC_.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
