using Api.Handlers.Requests;

namespace Api.Validations;

public interface IGetPersonById
{
    void Validate(GetPersonByIdRequest request);
}
