using Api.Handlers.Requests;

namespace Api.Validations;

public class GetPersonById : IGetPersonById
{
    public void Validate(GetPersonByIdRequest request)
    {
        if (request.Id == Guid.Empty)
            throw new ArgumentException("Id is invalid");
    }
}
