using Microsoft.AspNetCore.Mvc.Rendering;
using MVCPracticeLesson1.Entities;
using System.Collections.Generic;

namespace MVCPracticeLesson1.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}