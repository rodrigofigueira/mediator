using Api.Model;

namespace Api.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public async Task<Person> GetById(Guid Id)
        {
            await Task.Delay(0);
            return new(Id, "Name Test", "email@test.com");
        }

        public async Task<Guid> Post(string Name, string Email)
        {
            await Task.Delay(0);
            return Guid.NewGuid();
        }
    }
}
