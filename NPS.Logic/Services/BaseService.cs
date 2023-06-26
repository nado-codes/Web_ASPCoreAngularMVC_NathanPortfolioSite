using NPS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Logic.Services
{
    internal class BaseService<Model,Repo> : IBaseService<Model> where Model : IBaseModel where Repo : IBaseRepository<Model>
    {
        private readonly Repo _repository;

        public BaseService(Repo repository) {
            _repository = repository;
        }

        public Task<Model> AddAsync(Model item)
        {
            throw new NotImplementedException();
        }

        public Task<Model> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Model>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Model> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Model> UpdateAsync(Model item)
        {
            throw new NotImplementedException();
        }
    }
}
