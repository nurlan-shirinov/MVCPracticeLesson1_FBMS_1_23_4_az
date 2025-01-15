using MVCPracticeLesson1.Entities;
using System.Collections.Generic;

namespace MVCPracticeLesson1.Models
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}
