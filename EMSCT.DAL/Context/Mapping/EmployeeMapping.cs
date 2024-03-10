using EMSCT.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMSCT.DAL.Context.Mapping
{
    public class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
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

            builder.Property(a => a.Password)
                .HasColumnType("nvarchar")
                .HasColumnName("Password")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(a => a.BirthDate)
                .HasColumnType("DateTime")
                .HasColumnName("BirthDate");

            builder.Property(a => a.Email)
                .HasColumnType("nvarchar")
                .HasColumnName("Email")
                .HasMaxLength(75)
                .IsRequired();
        }
    }
}
