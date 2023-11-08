using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Location;

public class DepartmentConfig : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        /* Assign Table name */
        builder.ToTable("department");

        /* Assign PrimaryKey */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Assign Colums */
        builder.Property(na => na.Name)
        .IsRequired()
        .HasMaxLength(50);
        builder.HasIndex(na => na.Name)
        .IsUnique();

        /* Assign Foreign Key One to Many */
        builder.HasOne(fk => fk.Country)
        .WithMany(fk => fk.Departments)
        .HasForeignKey(fk => fk.IdCountryFk);
    }
}
