using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Medgrupo.Contacts.Infra.Contexts;
using Medgrupo.Contacts.Domain.Entities;
using Medgrupo.Contacts.Domain.Repositories;
using Medgrupo.Contacts.Domain.Queries;

namespace Medgrupo.Contacts.Infra.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private ContactsDbContext _ctx;

        public ContactRepository(ContactsDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Create(Contact contact)
        {
            _ctx.Contacts.Add(contact);
            _ctx.SaveChanges();
        } 

        public IEnumerable<Contact> GetAll()
        {
            return _ctx.Contacts
                    .AsNoTracking()
                    .ToList();
        }

        public Contact GetById(Guid id)
        {
            return _ctx
                .Contacts
                .FirstOrDefault(ContactQueries.GetById(id));
        }

        public void Update(Contact contact)
        {
            _ctx.Entry(contact).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Delete(Contact contact)
        {
            _ctx.Contacts.Remove(contact);
            _ctx.SaveChanges();
        }

    }
}
