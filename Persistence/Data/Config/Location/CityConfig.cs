using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Location;

public class CityConfig : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        /* Assign Table Name */
        builder.ToTable("city");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Assign Colums */
        builder.Property(na => na.Name)
        .IsRequired()
        .HasMaxLength(50);
        builder.HasIndex(na => na.Name)
        .IsUnique();

        /* Assign Foreign Key One to Many */
        builder.HasOne(one => one.Department)
        .WithMany(many => many.Cities)
        .HasForeignKey(fk => fk.IdDepartFk);
    }
}
