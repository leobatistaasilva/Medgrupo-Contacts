using System;
using System.Linq.Expressions;
using Medgrupo.Contacts.Domain.Entities;

namespace Medgrupo.Contacts.Domain.Queries
{
    public static class ContactQueries
    {
        public static Expression<Func<Contact, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

    }
}