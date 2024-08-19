using Api.Model;

namespace Api.Repository;

public interface IPersonRepository
{
    Task<Guid> Post(string Name, string Email);
    Task<Person> GetById(Guid Id);
}
