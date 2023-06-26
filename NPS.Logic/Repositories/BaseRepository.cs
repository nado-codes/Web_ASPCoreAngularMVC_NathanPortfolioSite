using NPS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Logic.Repositories
{
    internal class BaseRepository<M> : IBaseRepository<M> where M : IBaseModel
    {
        public Task<M> AddAsync(M item)
        {
            throw new NotImplementedException();
        }

        public Task<M> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<M>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<M> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<M> UpdateAsync(M item)
        {
            throw new NotImplementedException();
        }
    }
}
