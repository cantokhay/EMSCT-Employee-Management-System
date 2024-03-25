using EMSCT.DATA.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMSCT.INFRA.EntityTypeConfig
{
    internal class DepartmentConfigurations : BaseEntityConfigurations<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(500);

            base.Configure(builder);
        }
    }
}
