using System.Data.Entity;

namespace Students
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentContext")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}