using EMSCT.DAL.Mapping;
using EMSCT.DATA;
using Microsoft.EntityFrameworkCore;

namespace EMSCT.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OHO9G30\SQLEXPRESS;Database=EMSCT;Trusted_Connection=True;");
        }

        //automapper
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new DepartmentMapping().Configure(modelBuilder.Entity<Department>());
            new EmployeeMapping().Configure(modelBuilder.Entity<Employee>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
