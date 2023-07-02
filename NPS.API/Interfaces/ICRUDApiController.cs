using Microsoft.AspNetCore.Mvc;
using NPS.Interfaces;

namespace NPS.App.Interfaces
{
    public interface ICRUDApiController<Model,Service> where Model : IBaseModel where Service : IBaseService<Model>
    {
        public Task<IEnumerable<Model>> GetAllAsync();

        public Task<Model> GetAsync(long id);

        public Task<Model> AddAsync(Model item);

        public Task<int> UpdateAsync(Model item);

        public Task<int> DeleteAsync(long id);
    }
}
