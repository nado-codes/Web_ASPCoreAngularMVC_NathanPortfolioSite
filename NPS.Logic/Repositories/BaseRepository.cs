using NPS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Logic.Repositories
{
    internal class BaseRepository<Model> : IBaseRepository<Model> where Model : IBaseModel
    {
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
