using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.UserAuthen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.UserAuthen;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        /* Assign Table Name */
        builder.ToTable("user");

        /* Assign PrimaryKey */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id)
        .HasColumnType("int")
        .HasColumnName("id");

        /* Aggign Columns */
        builder.Property(p => p.Password)
        .HasColumnName("password")
        .HasColumnType("varchar")
        .HasMaxLength(30);

        /* Aggign Columns */
        builder.Property(e => e.Email)
        .HasColumnName("email")
        .HasColumnType("varchar")
        .HasMaxLength(50);

        /* Assign Foreign Key Many to Many */
        builder.HasMany(many => many.Roles)
        .WithMany(many => many.Users)
        .UsingEntity<UserRol>(
            j => j
            .HasOne(one => one.Rol)
            .WithMany(many => many.UserRols)
            .HasForeignKey(fk => fk.IdRolFk),

            j => j
            .HasOne(one => one.User)
            .WithMany(many => many.UserRols)
            .HasForeignKey(fk => fk.IdUserFk),

            j =>
            {
                j.ToTable("userrols");
                j.HasKey(t => new { t.IdUserFk, t.IdRolFk });
            }
        );

        /* Assign Foreign Key One to Many */
        builder.HasMany(many => many.RefreshTokens)
        .WithOne(one => one.User)
        .HasForeignKey(fk => fk.IdUserFk);

    }
}