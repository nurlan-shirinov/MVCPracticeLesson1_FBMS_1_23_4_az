using Microsoft.AspNetCore.Mvc;
using MVCPracticeLesson1.Services;
using System.Threading.Tasks;

namespace MVCPracticeLesson1.Controllers
{
    public class StudentController : Controller
    {
        private readonly  IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<IActionResult> Index(string key = "")
        {
            return View(await _studentService.GetAllByKey(key));
        }
    }
}