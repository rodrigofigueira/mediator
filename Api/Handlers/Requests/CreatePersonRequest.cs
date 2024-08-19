using Api.Model;
using MediatR;

namespace Api.Handlers.Commands;

public record CreatePersonRequest(string Name, string Email) : IRequest<Person> { }
