using Microsoft.AspNetCore.Mvc;

namespace MVCPracticeLesson1.Controllers
{
    public class DrinkController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
