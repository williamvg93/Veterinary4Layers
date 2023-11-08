using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.ProvidedServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.ProvidedServices;

public class AppointmentConfig : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        /* Assign Table name */
        builder.ToTable("appointment");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Assign Colums */
        builder.Property(d => d.Date)
        .HasColumnType("datetime");

        builder.Property(d => d.Time)
        .HasColumnType("time");

        /* Assign Foreign Key one to many */
        builder.HasOne(one => one.Client)
        .WithMany(many => many.Appointments)
        .HasForeignKey(fk => fk.IdClientFk);

        /* Assign Foreign Key one to many */
        builder.HasOne(one => one.Pet)
        .WithMany(many => many.Appointments)
        .HasForeignKey(fk => fk.IdPetFk);

        /* Assign Foreign Key one to many */
        builder.HasOne(one => one.Service)
        .WithMany(many => many.Appointments)
        .HasForeignKey(fk => fk.IdServiceFk);

    }
}