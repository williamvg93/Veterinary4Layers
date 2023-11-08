using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Pet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Pet;

public class PetBredConfig : IEntityTypeConfiguration<PetBred>
{
    public void Configure(EntityTypeBuilder<PetBred> builder)
    {
        /* Assign Table name */
        builder.ToTable("petbred");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Assign Colums */
        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);
        builder.HasIndex(n => n.Name)
        .IsUnique();
    }
}