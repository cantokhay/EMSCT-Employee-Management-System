using EMSCT.DATA.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMSCT.DAL.Config
{
    public class AppUserMapConfig : BaseEntityMapConfig<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("EmployeeId");

            builder.Property(a => a.UserName)
                .HasColumnType("nvarchar")
                .HasColumnName("Username")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Name)
                .HasColumnType("nvarchar")
                .HasColumnName("First Name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.LastName)
                .HasColumnType("nvarchar")
                .HasColumnName("Last Name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.BirthDate)
                .HasColumnType("DateTime")
                .HasColumnName("BirthDate");

            builder.Property(a => a.Email)
                .HasColumnType("nvarchar")
                .HasColumnName("Email")
                .HasMaxLength(75)
                .IsRequired();

            //one to many with department
            builder.HasOne(a => a.Department)
                .WithMany(a => a.Employees)
                .HasForeignKey(a => a.DepartmentId)
                .HasConstraintName("Department of Employee")
                .OnDelete(DeleteBehavior.NoAction);

            base.Configure(builder);
        }
    }
}
