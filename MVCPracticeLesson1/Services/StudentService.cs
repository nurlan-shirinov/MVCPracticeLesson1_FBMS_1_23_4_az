using MVCPracticeLesson1.Entities;
using MVCPracticeLesson1.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPracticeLesson1.Services
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        public async Task<List<Student>> GetAllByKey(string key = "")
        {
            var data = await studentRepository.GetAll();

            return key != "" 
                ? (data.Where(s=>s.Firstname.ToLower().Contains(key.ToLower()))).ToList() 
                : data;
        }
    }
}