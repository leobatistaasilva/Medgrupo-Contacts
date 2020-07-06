using System;
using Medgrupo.Contacts.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medgrupo.Contacts.Infra.Data.Mappings
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.Property(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(160).HasColumnType("varchar(255)");
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Birth).IsRequired();
            builder.Property(x => x.Gender).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.CreateDate).IsRequired().HasDefaultValueSql("GetDate()");
            builder.Property(x => x.LastUpdateDate).IsRequired();

        }
        
    }
}