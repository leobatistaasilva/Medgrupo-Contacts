using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medgrupo.Contacts.Domain.Commands;
using System;

namespace Medgrupo.Contacts.Tests.Commands
{
    [TestClass]
    public class CreateContactCommandTests
    {
        private readonly CreateContactCommand _validCommand;
        private readonly CreateContactCommand _invalidCommand;

        public CreateContactCommandTests()
        {
            _validCommand = new CreateContactCommand("Leonardo", "Masculino", new DateTime(1984, 2, 16));
            _invalidCommand = new CreateContactCommand("", "", new DateTime());
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            _invalidCommand.Validate();
            Assert.AreEqual(_invalidCommand.Valid, false);
        }
        
        [TestMethod]
        public void Dado_um_comando_valido()
        {
            _validCommand.Validate();
            Assert.AreEqual(_validCommand.Valid, true);
        }        

        [TestMethod]
        public void Dado_um_nascimento_futuro_comando_deve_ser_invalido()
        {
            _validCommand.Birth = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
            _validCommand.Validate();
            Assert.AreEqual(_validCommand.Valid, false);
        }          
    }
}
