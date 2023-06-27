using Microsoft.EntityFrameworkCore;

namespace APISTUDENT.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

    }
}
