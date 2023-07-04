using NPS.Interfaces;

namespace NPS.Api.Services
{
    public class BaseService<Model,Repo> : IBaseService<Model> where Model : IBaseModel where Repo : IBaseRepository<Model>
    {
        private readonly Repo _repository;

        public BaseService(Repo repository) {
            _repository = repository;
        }

        public Task<Model> AddAsync(Model item)
        {
            return _repository.AddAsync(item);
        }

        public Task<int> DeleteAsync(long id)
        {
            return _repository.DeleteAsync(id);
        }

        public Task<IEnumerable<Model>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public Task<Model> GetAsync(long id)
        {
            return _repository.GetAsync(id);
        }

        public Task<int> UpdateAsync(Model item)
        {
            return _repository.UpdateAsync(item);
        }
    }
}
