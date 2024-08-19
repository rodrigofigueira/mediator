using Api.Model;
using MediatR;

namespace Api.Handlers.Requests
{
    public class GetPersonByIdRequest(Guid id) : IRequest<Person>
    {
        public Guid Id = id;
    }
}
