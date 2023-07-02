
namespace NPS.Interfaces
{
    public interface IBaseRepository<M> where M : IBaseModel
    {
        public Task<IEnumerable<M>> GetAllAsync();

        public Task<M> GetAsync(long id);

        public Task<M> AddAsync(M item);

        public Task<int> UpdateAsync(M item);

        public Task<int> DeleteAsync(long id);
    }
}
