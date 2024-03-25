using EMSCT.DATA.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMSCT.INFRA.EntityTypeConfig
{
    internal class AppUserConfigurations : BaseEntityConfigurations<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.Address).IsRequired().HasMaxLength(500);
            builder.Property(x => x.TCKN).IsRequired().HasMaxLength(11);

            base.Configure(builder);
        }
    }
}
