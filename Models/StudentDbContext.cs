using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    public class StudentDbContext:DbContext
    {
        private readonly IConfiguration _configuration;

        public StudentDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:SQLServerConnection"]);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne(e => e.departments).WithMany(a => a.students).HasForeignKey(e => e.deptid);


            base.OnModelCreating(modelBuilder);
        }
    }
}
