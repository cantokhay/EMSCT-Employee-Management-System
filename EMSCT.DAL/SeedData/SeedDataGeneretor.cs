using Bogus;
using EMSCT.DAL.Context;
using EMSCT.DATA.Entities.Concrete;
using EMSCT.DATA.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMSCT.DAL.SeedData
{
    public static class SeedDataGenerator
    {
        static List<AppUser> appUsers = new();
        static List<Department> departments = new();

        public static async Task Seed(IApplicationBuilder app, int maxDepartmentCount, int maxEmployeeCountPerDepartment)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                AppDbContext context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                context.Database.Migrate();
                await CreateRolesAsync(serviceScope);

                if (!await context.Departments.AnyAsync())
                {
                    await CreateFakeDepartmentsAsync(maxDepartmentCount);
                    await context.Departments.AddRangeAsync(departments);
                }

                if (!await context.Employees.AnyAsync())
                {
                    await CreateFakeEmployeesAsync(maxEmployeeCountPerDepartment, userManager); // Pass userManager as a parameter
                }

                await context.SaveChangesAsync();
            }
        }

        private static async Task CreateFakeDepartmentsAsync(int maxDepartmentCount)
        {
            for (int i = 0; i < maxDepartmentCount; i++)
            {
                var departmentFake = new Faker<Department>()
                    .RuleFor(d => d.Id, f => f.Random.Int())
                    .RuleFor(d => d.Name, f => f.Commerce.Department())
                    .RuleFor(d => d.Description, f => f.Lorem.Sentence())
                    .RuleFor(d => d.CreateDate, f => f.Date.Past(1))
                    .RuleFor(d => d.Status, f => f.Random.Bool(0.9f) ? Status.Active : (f.Random.Bool(0.5f) ? Status.Modified : (f.Random.Bool(0.25f) ? Status.Inactive : Status.Deleted)));

                departments.Add(departmentFake.Generate());
            }

            foreach (var department in departments)
            {
                if (department.Status == Status.Deleted)
                {
                    department.DeleteDate = GetRandomDayAfterCreateDate(department.CreateDate);
                }
                if (department.Status == Status.Modified)
                {
                    department.UpdateDate = GetRandomDayAfterCreateDate(department.CreateDate);
                }
            }
        }

        private static async Task CreateFakeEmployeesAsync(int maxEmployeeCountPerDepartment, UserManager<AppUser> userManager)
        {
            Random rnd = new Random();
            for (int j = 0; j < rnd.Next(1, maxEmployeeCountPerDepartment); j++)
            {
                var employeeFake = new Faker<AppUser>()
                    .RuleFor(e => e.Id, f => f.Random.Int())
                    .RuleFor(e => e.Name, f => f.Name.FirstName())
                    .RuleFor(e => e.LastName, f => f.Name.LastName())
                    .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.Name, e.LastName).ToLowerInvariant())
                    .RuleFor(e => e.NormalizedEmail, (f, e) => e.Email.ToUpperInvariant())
                    .RuleFor(e => e.EmailConfirmed, _ => true)
                    .RuleFor(e => e.UserName, (f, e) => e.Email)
                    .RuleFor(e => e.NormalizedUserName, (f, e) => e.UserName.ToUpperInvariant())
                    .RuleFor(e => e.Address, f => f.Address.FullAddress())
                    .RuleFor(e => e.PhoneNumber, f => f.Phone.PhoneNumber("+90##########"))
                    .RuleFor(e => e.TCKN, f => f.Random.ReplaceNumbers($"###########"))
                    .RuleFor(e => e.BirthDate, f => f.Date.Between(DateTime.Now.AddYears(-40), DateTime.Now.AddYears(-18)))
                    .RuleFor(e => e.Gender, f => f.PickRandom<Gender>())
                    .RuleFor(c => c.CreateDate, f => f.Date.Past(1))
                    .RuleFor(e => e.Status, f => f.Random.Bool(0.9f) ? Status.Active : (f.Random.Bool(0.5f) ? Status.Modified : (f.Random.Bool(0.25f) ? Status.Inactive : Status.Deleted)))
                    .RuleFor(e => e.DepartmentId, f => f.PickRandom(departments).Id);

                appUsers.Add(employeeFake.Generate());
            }

            foreach (var appUser in appUsers)
            {
                if (appUser.Status == Status.Deleted)
                {
                    appUser.DeleteDate = GetRandomDayAfterCreateDate(appUser.CreateDate);
                }
                if (appUser.Status == Status.Modified)
                {
                    appUser.UpdateDate = GetRandomDayAfterCreateDate(appUser.CreateDate);
                }

                string password = "Pr123+";
                await userManager.CreateAsync(appUser, password);
                await userManager.AddToRoleAsync(appUser, "Personel");
            }
        }

        private static async Task CreateRolesAsync(IServiceScope serviceScope)
        {
            var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            var roles = new[] { "Personel" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole<Guid>(role));
            }
        }

        private static DateTime GetRandomDayAfterCreateDate(DateTime createdDate)
        {
            int range = (DateTime.Today - createdDate).Days;
            Random rnd = new Random();
            return createdDate.AddDays(rnd.Next(range));
        }
    }
}