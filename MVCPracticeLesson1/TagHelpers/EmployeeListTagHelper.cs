using Microsoft.AspNetCore.Razor.TagHelpers;
using MVCPracticeLesson1.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCPracticeLesson1.TagHelpers
{

    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        public List<Employee> _employees;

        public EmployeeListTagHelper()
        {
            _employees = new()
            {
                new Employee
                {
                    Id = 1,
                    Firstname="Vagif",
                    Lastname="Qasimov",
                    CityId=1
                },
                 new Employee
                {
                    Id = 2,
                    Firstname="Ahmed",
                    Lastname="Huseyinli",
                    CityId=2
                },
                  new Employee
                {
                    Id = 3,
                    Firstname="Mirtalib",
                    Lastname="Amirli",
                    CityId=1
                },       
                new Employee
                {
                    Id = 4,
                    Firstname="Logman",
                    Lastname="Quliyev",
                    CityId=1
                },
                  new Employee
                {
                    Id = 4,
                    Firstname="Taleh",
                    Lastname="Haciyev",
                    CityId=1
                }
            };
        }

        private const string ListCountAttribute = "count";

        [HtmlAttributeName(ListCountAttribute)]
        public int ListCount { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            var query = _employees;
            if (ListCount!=0)
                query = _employees.Take(ListCount).ToList();

            StringBuilder sb = new();
            foreach ( var item in query )
            {
                sb.AppendFormat("<h2><a href = 'employee/detail/{0}'>{1}</a></h2>" , item.Id , item.Firstname);
            }
            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}