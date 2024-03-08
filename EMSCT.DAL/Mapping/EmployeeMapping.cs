using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using EMSCT.DATA;

namespace EMSCT.DAL.Mapping
{
    public class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.ToTable("Employee");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
                .UseIdentityColumn()
                .HasColumnName("EmployeeID");

            builder.Property(a => a.UserName)
                .HasColumnType("nvarchar")
                .HasColumnName("UserName")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Email)
                .HasColumnType("nvarchar")
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.PasswordHash)
                .HasColumnType("nvarchar")
                .HasColumnName("PasswordHash")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(a => a.Gender)
                .HasColumnType("nvarchar")
                .HasColumnName("Gender")
                .HasMaxLength(5);
            //.IsRequired();

            builder.Property(a => a.BirthDate)
                .HasColumnType("DateTime")
                .HasColumnName("BirthDate");
            //.IsRequired();
        }
    }
}
