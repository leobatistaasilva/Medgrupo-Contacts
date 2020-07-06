using System;
using System.Collections.Generic;
using Medgrupo.Contacts.Domain.Commands;
using Medgrupo.Contacts.Domain.Entities;
using Medgrupo.Contacts.Domain.Handlers;
using Medgrupo.Contacts.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Medgrupo.Contacts.Api.Controllers
{
    [ApiController]
    [Route("v1/contacts")]
    public class ContactController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Contact> GetAll(
            [FromServices]IContactRepository repository
        )
        {
            return repository.GetAll();
        }

        [HttpPost]
        public GenericCommandResult Create(
            [FromBody]CreateContactCommand command,
            [FromServices]ContactHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        
        [HttpPut]
        public GenericCommandResult Update(
           [FromBody] UpdateContactCommand command,
           [FromServices] ContactHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [HttpDelete]
        public GenericCommandResult Delete(
           [FromBody] DeleteContactCommand command,
           [FromServices] ContactHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("{id}")]
        [HttpGet]
        public Contact Get(
            [FromRoute]Guid id,
            [FromServices] IContactRepository repository)
        {
            return repository.GetById(id);
        }


    }
}