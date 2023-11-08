using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Pet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Pet;

public class PetConfig : IEntityTypeConfiguration<CPet>
{
    public void Configure(EntityTypeBuilder<CPet> builder)
    {
        /* Assign Table name */
        builder.ToTable("pet");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Assign Colums */
        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(bd => bd.BirthDate)
        .HasColumnType("datetime");

        /* Assign Foreign Key One to Many */
        builder.HasOne(one => one.Client)
        .WithMany(many => many.Pets)
        .HasForeignKey(f => f.IdClientFk);

        /* Assign Foreign Key One to Many */
        builder.HasOne(one => one.PetBred)
        .WithMany(many => many.Pets)
        .HasForeignKey(f => f.IdPetBredFk);
    }
}