using MVCPracticeLesson1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCPracticeLesson1.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAll();
        void Add(Student student);
    }
}