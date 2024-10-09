using Microsoft.EntityFrameworkCore;
using School.Domain.Entities.Classes;
using School.Domain.Entities.Students;
namespace School.Infrastructure.Contexts
{
    public class SchoolDB : DbContext
    {
        public SchoolDB(DbContextOptions<SchoolDB> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId);
        }
    }
}
