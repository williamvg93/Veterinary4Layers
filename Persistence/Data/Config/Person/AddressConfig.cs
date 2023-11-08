using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Location;
using Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Person;

public class AddressConfig : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        /* Assign Table name */
        builder.ToTable("address");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Assign Colums */
        builder.Property(r => r.TypeRoad)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(fn => fn.FirstNumber)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(fl => fl.FirstLetter)
        .IsRequired()
        .HasMaxLength(1);

        builder.Property(b => b.Bis)
        .IsRequired()
        .HasMaxLength(3);

        builder.Property(sl => sl.SecondLetter)
        .IsRequired()
        .HasMaxLength(2);

        builder.Property(c => c.Cardinal)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(sn => sn.SecondNumber)
        .HasColumnType("int");

        builder.Property(tl => tl.ThirdLetter)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(tn => tn.ThirdNumber)
        .HasColumnType("int");

        builder.Property(sc => sc.SecondCardinal)
        .IsRequired()
        .HasMaxLength(10);

        builder.Property(com => com.Complement)
        .HasMaxLength(50);

        builder.Property(pos => pos.PostalCode)
        .HasMaxLength(10);

        /* Assign Foreign Key One To One */
        builder.HasOne(one => one.Client)
        .WithOne(one => one.Address)
        .HasForeignKey<Address>(fk => fk.IdCityFk);

        /* Assign Foreign Key One to Many */
        builder.HasOne(one => one.City)
        .WithMany(many => many.Addresses)
        .HasForeignKey(fk => fk.IdCityFk);
    }

}