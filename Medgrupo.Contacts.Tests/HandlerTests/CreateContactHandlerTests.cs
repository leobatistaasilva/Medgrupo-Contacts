using Medgrupo.Contacts.Domain.Commands;
using Medgrupo.Contacts.Domain.Handlers;
using Medgrupo.Contacts.Tests.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Medgrupo.Contacts.Tests.HandlerTests
{
    [TestClass]
    public class CreateContactHandlerTests
    {
        private readonly CreateContactCommand _validCommand;
        private readonly CreateContactCommand _invalidCommand;
        private ContactHandler _handler;

        private GenericCommandResult _result;

        public CreateContactHandlerTests()
        {
            _validCommand = new CreateContactCommand("Leonardo", "Masculino", new DateTime(1984, 2, 16)); ;
            _invalidCommand = new CreateContactCommand("", "", new DateTime());            
            _handler = new ContactHandler(new FakeContactRepository());
            _result = new GenericCommandResult();
        }


        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_a_execucao()
        {
            _result = (GenericCommandResult) _handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }
        
        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_o_contato()
        {
            _result = (GenericCommandResult) _handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }

        public void Dado_comando_invalido_com_nascimento_futuro_deve_interromper_a_execucao()
        {
            _validCommand.Birth = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);
            _validCommand.Validate();
            Assert.AreEqual(_validCommand.Valid, false);
        }
    }
}