using System;
using Flunt.Notifications;
using Flunt.Validations;
using Medgrupo.Contacts.Domain.Commands.Contracts;

namespace Medgrupo.Contacts.Domain.Commands
{
    public class UpdateContactCommand : Notifiable, ICommand
    {
        public UpdateContactCommand() { }

        public UpdateContactCommand(Guid id, string name, string gender, DateTime birth)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Birth = birth;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birth { get; set; }

        public void Validate()
        {
            DateTime dateBirth;

            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotEmpty(Id, "Id", "Contato sem identificador!")
                    .Requires()
                    .HasMinLen(Name, 5, "Name", "Por favor, digite o nome do contato!")
                    .HasMinLen(Gender, 4, "Gender", "Por favor, digite o g�nero!")
                    .IsTrue(DateTime.TryParse(Birth.ToString(), out dateBirth), "Birth", "Por favor, digite uma data de nascimento v�lida!")
            );
        }
    }
}