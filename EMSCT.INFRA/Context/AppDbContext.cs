using EMSCT.DATA.Entities.Concrete;
using EMSCT.INFRA.EntityTypeConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EMSCT.INFRA.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions opt) : base(opt) { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserConfigurations());
            builder.ApplyConfiguration(new DepartmentConfigurations());
            base.OnModelCreating(builder);
        }
    }
}
