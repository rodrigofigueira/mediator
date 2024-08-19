using Api.Handlers.Requests;
using Api.Model;
using Api.Repository;
using Api.Validations;
using MediatR;

namespace Api.Handlers;

public class GetPersonByIdHandler(IGetPersonById validationGetPerson
                                , IPersonRepository personRepository) : IRequestHandler<GetPersonByIdRequest, Person>
{
    private readonly IGetPersonById _validationGetPerson = validationGetPerson;
    private readonly IPersonRepository _personRepository = personRepository;

    public async Task<Person> Handle(GetPersonByIdRequest request, CancellationToken cancellationToken)
    {
        _validationGetPerson.Validate(request);
        return await _personRepository.GetById(request.Id);
    }
}
