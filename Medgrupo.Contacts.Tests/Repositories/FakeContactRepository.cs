using System;
using System.Collections.Generic;
using Medgrupo.Contacts.Domain.Entities;
using Medgrupo.Contacts.Domain.Repositories;
using System.Linq;


namespace Medgrupo.Contacts.Tests.Repositories
{
    public class FakeContactRepository : IContactRepository
    {
        public void Create(Contact contact)
        {
            // throw new NotImplementedException();
        }

        public void Delete(Contact contact)
        {
            // throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {
            return new List<Contact>{
                new Contact("Leonardo","Masculino", new DateTime(1984,2,16)),
                new Contact("Arthur","Masculino", new DateTime(2015,3,21)),
                new Contact("Aidenir","Feminino", new DateTime(1954,5,10)),
                new Contact("Ana Paula","Feminino", new DateTime(1994,6,14))
            };
        }

        public Contact GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}