using System;
using System.Collections.Generic;
using Medgrupo.Contacts.Domain.Entities;

namespace Medgrupo.Contacts.Domain.Repositories
{
    public interface IContactRepository
    {
        void Create(Contact Contact);
        void Update(Contact Contact);
        Contact GetById(Guid id);
        IEnumerable<Contact> GetAll();
        void Delete(Contact Contact);        
    }
}