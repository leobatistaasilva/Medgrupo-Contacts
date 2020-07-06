using Flunt.Notifications;
using Medgrupo.Contacts.Domain.Commands;
using Medgrupo.Contacts.Domain.Commands.Contracts;
using Medgrupo.Contacts.Domain.Entities;
using Medgrupo.Contacts.Domain.Handlers.Contracts;
using Medgrupo.Contacts.Domain.Repositories;

namespace Medgrupo.Contacts.Domain.Handlers
{
    public class ContactHandler :
        Notifiable,
        IHandler<CreateContactCommand>
    {
        private readonly IContactRepository _repository;

        public ContactHandler(IContactRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateContactCommand command)
        {           
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que os dados do contato estão errados!", command.Notifications);

            var Contact = new Contact(command.Name, command.Gender, command.Birth);

            // Salva no banco
            _repository.Create(Contact);

            // Retorna o resultado
            return new GenericCommandResult(true, "Contato salvo com sucesso!", Contact);
        }

        public ICommandResult Handle(UpdateContactCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que os dados do contato estão errados!", command.Notifications);

            // Recupera 
            var Contact = _repository.GetById(command.Id);

            // modificacoes
            Contact.UpdateName(command.Name);
            Contact.ChangeGender(command.Gender);
            Contact.ChangeDateBirth(command.Birth);

            // salva no banco
            _repository.Update(Contact);

            // Retorna o resultado
            return new GenericCommandResult(true, "Contato salvo com sucesso!", Contact);
        }

        public ICommandResult Handle(DeleteContactCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que os dados do contato estão errados!", command.Notifications);

            // Recupera 
            var Contact = _repository.GetById(command.Id);
            
            // apaga no banco
            _repository.Delete(Contact);

            // Retorna o resultado
            return new GenericCommandResult(true, "Contato apagado com sucesso!", Contact);
        }



    }
}