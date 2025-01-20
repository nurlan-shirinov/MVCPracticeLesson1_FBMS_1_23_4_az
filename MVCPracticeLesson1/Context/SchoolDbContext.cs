using Microsoft.EntityFrameworkCore;
using MVCPracticeLesson1.Entities;

namespace MVCPracticeLesson1.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}