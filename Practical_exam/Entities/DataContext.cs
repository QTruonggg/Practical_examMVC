using Microsoft.EntityFrameworkCore;
using Practical_exam.Entities;

namespace Practical_exam.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }
        public DbSet<Exam> exams { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Subject> subject { get; set; }
        public DbSet<Faculty> faculty { get; set; }
    }
}