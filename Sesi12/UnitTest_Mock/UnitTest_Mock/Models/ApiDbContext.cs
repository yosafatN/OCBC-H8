using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UnitTest_Mock.Models
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
