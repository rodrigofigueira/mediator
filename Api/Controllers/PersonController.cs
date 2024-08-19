using Api.Handlers.Commands;
using Api.Handlers.Requests;
using Api.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api")]
public class PersonController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost]
    public async Task<Person> Post(Person person) => await _mediator.Send(new CreatePersonRequest(person.Name, person.Email));

    [HttpGet]
    [Route("id/{id}")]
    public async Task<Person> GetById([FromRoute] Guid id) => await _mediator.Send(new GetPersonByIdRequest(id));
}
