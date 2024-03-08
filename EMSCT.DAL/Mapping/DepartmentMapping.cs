using EMSCT.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMSCT.DAL.Mapping
{
    public class DepartmentMapping : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("DepartmentID");

            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
        }
    }
}
