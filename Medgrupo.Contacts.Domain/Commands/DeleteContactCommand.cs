using System;
using Flunt.Notifications;
using Flunt.Validations;
using Medgrupo.Contacts.Domain.Commands.Contracts;

namespace Medgrupo.Contacts.Domain.Commands
{
    public class DeleteContactCommand : Notifiable, ICommand
    {
        public DeleteContactCommand() { }

        public DeleteContactCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }


        public void Validate()
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotEmpty(Id,"Id","Contato sem identificador!")
            );
        }
    }
}