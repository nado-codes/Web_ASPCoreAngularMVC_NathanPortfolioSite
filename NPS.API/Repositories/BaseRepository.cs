using NPS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Api.Repositories
{
    public class BaseRepository<Model> : IBaseRepository<Model> where Model : IBaseModel
    {
        public virtual Task<Model> AddAsync(Model item)
        {
            throw new NotImplementedException();
        }

        public virtual Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<Model>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<Model> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<int> UpdateAsync(Model item)
        {
            throw new NotImplementedException();
        }
    }
}
