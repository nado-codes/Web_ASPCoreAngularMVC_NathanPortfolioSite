using Microsoft.AspNetCore.Mvc;
using NPS.App.Interfaces;
using NPS.Interfaces;

namespace NPS.App.Controllers
{
    public class CRUDApiController<Model,Service> : ControllerBase, ICRUDApiController<Model, Service> where Model : IBaseModel where Service : IBaseService<Model>
    {
        private readonly Service _service;

        public CRUDApiController(Service service)
        {
            _service = service;
        }

        [HttpPost]
        public Task<Model> AddAsync(Model item)
        {
            return _service.AddAsync(item);
        }

        [HttpDelete]
        public Task<int> DeleteAsync(long id)
        {
            return _service.DeleteAsync(id);
        }

        [HttpGet]
        public Task<IEnumerable<Model>> GetAllAsync()
        {
            return _service.GetAllAsync();
        }

        [HttpGet("/id/{id:long}")]
        public Task<Model> GetAsync(long id)
        {
            return _service.GetAsync(id);
        }

        [HttpPut]
        public Task<int> UpdateAsync(Model item)
        {
            return _service.UpdateAsync(item);
        }
    }
}
