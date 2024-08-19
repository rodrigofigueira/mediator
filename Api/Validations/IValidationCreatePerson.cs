using Api.Handlers.Commands;

namespace Api.Validations
{
    public interface IValidationCreatePerson
    {
        void Validate(CreatePersonRequest createPersonRequest);
    }
}
