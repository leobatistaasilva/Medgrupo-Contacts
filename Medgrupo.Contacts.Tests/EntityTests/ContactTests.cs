using Medgrupo.Contacts.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Medgrupo.Contacts.Tests.EntityTests
{
    [TestClass]
    public class ContactTests
    {
        private readonly Contact _validContact;

        public ContactTests()
        {
            _validContact = new Contact("Leonardo", "Masculino", new DateTime(1984, 2, 16));
        }

        [TestMethod]
        public void Dado_uma_novo_contato_o_mesmo_tem_que_ter_data_de_criacao()
        {
            Assert.AreEqual(_validContact.CreateDate == null, false);
        }

        [TestMethod]
        public void Dado_uma_novo_contato_o_mesmo_tem_que_ter_idade_gerada_automatica()
        {
            Console.WriteLine(_validContact.Age.ToString());
            Assert.AreEqual(_validContact.Age > 0, true);
        }

    }
}