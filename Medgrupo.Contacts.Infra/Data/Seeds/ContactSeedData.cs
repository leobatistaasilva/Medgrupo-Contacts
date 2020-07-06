using Medgrupo.Contacts.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Medgrupo.Contacts.Infra.Data.Seeds
{
    internal class ContactSeedData
    {
        internal static List<Contact> Seed()
        {
            return new List<Contact>
            {
                new Contact("Leonardo","Masculino", new DateTime(1984,2,16)),
                new Contact("Arthur","Masculino", new DateTime(2015,3,21)),
                new Contact("Aidenir","Feminino", new DateTime(1954,5,10)),
                new Contact("Ana Paula","Feminino", new DateTime(1994,6,14))
            };
        }
    }
}
