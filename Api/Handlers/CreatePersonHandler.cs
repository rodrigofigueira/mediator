using Api.Handlers.Commands;
using Api.Model;
using Api.Repository;
using Api.Validations;
using MediatR;

namespace Api.Handlers;

public class CreatePersonHandler(IValidationCreatePerson validationCreatePerson
                                , IPersonRepository personRepository)
            : IRequestHandler<CreatePersonRequest, Person>
{
    private readonly IValidationCreatePerson _validationCreatePerson = validationCreatePerson;
    private readonly IPersonRepository _personRepository = personRepository;

    public async Task<Person> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
    {
        _validationCreatePerson.Validate(request);
        Guid id = await _personRepository.Post(request.Name, request.Email);

        if (id == Guid.Empty)
        {
            throw new Exception("Person wasn't created");
        }

        return new(id, request.Name, request.Email);
    }
}
