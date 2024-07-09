using Microsoft.EntityFrameworkCore;
using StudentWebApplication.Models;

namespace StudentWebApplication.Repositories
{
    public class CollectionContext : DbContext
    {
        public DbSet<Student> student {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = @"server=localhost;port=3306;user=root;password=Sakshi@123;database=productmanage";
            optionsBuilder.UseMySQL(connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.name);
                entity.Property(e => e.email);
                entity.Property(e => e.mobileno);
                entity.Property(e => e.address);
                entity.Property(e => e.admission_date);
                entity.Property(e => e.fees);
                entity.Property(e => e.status);
            });
            modelBuilder.Entity<Student>().ToTable("students");
        }
    }
}
