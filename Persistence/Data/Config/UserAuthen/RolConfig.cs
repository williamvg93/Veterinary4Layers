using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.UserAuthen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.UserAuthen;

public class RolConfig : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        /* Assign Table Name */
        builder.ToTable("rol");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Aggign Columns */
        builder.Property(n => n.Name)
        .HasColumnName("name")
        .HasColumnType("varchar")
        .HasMaxLength(50)
        .IsRequired();
        builder.HasIndex(n => n.Name)
        .IsUnique();
    }
}