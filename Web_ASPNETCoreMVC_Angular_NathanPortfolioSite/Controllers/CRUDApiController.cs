using Microsoft.AspNetCore.Mvc;
using NPS.App.Interfaces;
using NPS.Interfaces;

namespace NPS.App.Controllers
{
    internal class CRUDApiController<Model,Service> : ControllerBase, ICRUDApiController<Model, Service> where Model : IBaseModel where Service : IBaseService<Model>
    {
        private readonly Service _service;

        public CRUDApiController(Service service)
        {
            _service = service;
        }

        [HttpPost]
        public Task<Model> AddAsync(Model item)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public Task<Model> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public Task<IEnumerable<Model>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        [HttpGet("/id/{id:long}")]
        public Task<Model> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public Task<Model> UpdateAsync(Model item)
        {
            throw new NotImplementedException();
        }
    }
}
