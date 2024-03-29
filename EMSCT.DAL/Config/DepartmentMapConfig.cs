﻿using EMSCT.DATA.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMSCT.DAL.Config
{
    public class DepartmentMapConfig : BaseEntityMapConfig<Department>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            builder.HasKey(d => d.Id);

            builder.Property(a => a.Id)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("DepartmentId");

            builder.Property(d => d.Name)
                .HasColumnType("nvarchar")
                .HasColumnName("Department Name")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(d => d.Description)
                .HasColumnType("nvarchar")
                .HasColumnName("Department Description")
                .HasMaxLength(200);

            base.Configure(builder);
        }
    }
}
