using Api.Handlers.Commands;

namespace Api.Validations
{
    public class ValidationCreatePerson : IValidationCreatePerson
    {
        public void Validate(CreatePersonRequest createPersonRequest)
        {
            if (createPersonRequest.Name.Length < 10)
                throw new ArgumentException("Name is less than 10 characters");

            if (!createPersonRequest.Email.Contains("@"))
                throw new ArgumentException("Email is invalid");
        }
    }
}
