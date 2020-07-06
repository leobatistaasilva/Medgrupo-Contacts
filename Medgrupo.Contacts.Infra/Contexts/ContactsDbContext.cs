using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Medgrupo.Contacts.Domain.Entities;
using Medgrupo.Contacts.Infra.Data.Mappings;
using Medgrupo.Contacts.Infra.Data.Seeds;

namespace Medgrupo.Contacts.Infra.Contexts
{
    public class ContactsDbContext : DbContext
    {

        public ContactsDbContext(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.Entity<Contact>().HasData(ContactSeedData.Seed());
        }        

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ContactsDB;User ID=SA;Password=Mudar@4321;MultipleActiveResultSets=true;");
        //    }
        //}

        public DbSet<Contact> Contacts { get; set; }
    }
}
