using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCPracticeLesson1.Entities;
using MVCPracticeLesson1.Models;
using System.Collections.Generic;

namespace MVCPracticeLesson1.Controllers
{
    public class EmployeeController : Controller
    {
        //Default olaraq HTTP verb GET methodu olur

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem {Text="Baku", Value="10"},
                    new SelectListItem {Text="Sumqayit", Value="50"},
                    new SelectListItem {Text="Agdam", Value="02"},
                    new SelectListItem {Text="Masalli", Value="44"}
                }
            };

            return View(vm);
        }
        
        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/home/index");
            }
            return View(viewModel);
        }
    }
}