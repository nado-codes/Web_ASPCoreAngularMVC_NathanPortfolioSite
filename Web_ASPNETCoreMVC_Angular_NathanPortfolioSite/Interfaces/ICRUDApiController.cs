using NPS.Logic.Interfaces;

namespace NPS.App.Interfaces
{
    public interface ICRUDApiController<M> where M : IBaseModel
    {
        public Task<IEnumerable<M>> GetAllAsync();

        public Task<M> GetAsync(long id);

        public Task<M> AddAsync(M item);

        public Task<M> UpdateAsync(M item);

        public Task<M> DeleteAsync(long id);
    }
}
