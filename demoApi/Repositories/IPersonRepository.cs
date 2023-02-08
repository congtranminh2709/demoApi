using demoApi.Models;

namespace demoApi.Repositories
{
    public interface IPersonRepository
    {
        public Task<List<PersonModel>> GetAllAsync();
        public Task<PersonModel> GetByIdAsync(int id);
        public Task<int> AddAsync(PersonModel person);
        public Task<int> UpdateAsync(int id, PersonModel person);
        public Task<int> DeleteAsync(int id);
    }
}
