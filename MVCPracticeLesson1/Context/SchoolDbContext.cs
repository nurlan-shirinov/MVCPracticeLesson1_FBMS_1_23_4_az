using Microsoft.EntityFrameworkCore;

namespace MVCPracticeLesson1.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
    }
}