using System;
using Medgrupo.Contacts.Tests.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Medgrupo.Contacts.Tests.QueryTests
{
    [TestClass]
    public class ContactQueryTests
    {
        private FakeContactRepository _contactRepo;
        public ContactQueryTests()
        {
            _contactRepo = new FakeContactRepository();
        }
        
        [TestMethod]
        public void Dada_a_consulta_deve_retornar_os_contatos()
        {
            Assert.IsTrue(_contactRepo.GetAll().Count() > 0);
        }
    }
    
}