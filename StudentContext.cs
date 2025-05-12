using System.Data.Entity;

namespace StudentManagementApp.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext() : base("name=StudentContext")
        {
        }
    }
}
