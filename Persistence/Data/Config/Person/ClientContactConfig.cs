using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Config.Person;

public class ClientContactConfig : IEntityTypeConfiguration<ClientContact>
{
    public void Configure(EntityTypeBuilder<ClientContact> builder)
    {
        /* Assign Table name */
        builder.ToTable("clientcontact");

        /* Assign Primary Key */
        builder.HasKey(pk => pk.Id);
        builder.Property(pk => pk.Id);

        /* Assign Colums */
        builder.Property(n => n.Number)
        .IsRequired()
        .HasMaxLength(20);

        /* Assign Foreign Key One to Many */
        builder.HasOne(one => one.Client)
        .WithMany(mani => mani.ClientContacts)
        .HasForeignKey(f => f.IdClientFk);
    }
}