using Microsoft.EntityFrameworkCore;
using MVCPracticeLesson1.Context;
using MVCPracticeLesson1.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCPracticeLesson1.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _context;

        public StudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public async Task<List<Student>> GetAll()
        {
            return await _context.Students.ToListAsync();
        }
    }
}