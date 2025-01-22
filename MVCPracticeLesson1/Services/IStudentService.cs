using MVCPracticeLesson1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCPracticeLesson1.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllByKey(string key="");
    }
}