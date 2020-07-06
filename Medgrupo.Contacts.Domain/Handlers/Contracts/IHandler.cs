using Medgrupo.Contacts.Domain.Commands.Contracts;

namespace Medgrupo.Contacts.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}