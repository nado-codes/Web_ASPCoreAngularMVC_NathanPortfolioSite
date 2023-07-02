using NPS.Api.Interfaces;
using NPS.Api.Models;
using NPS.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Tests.Mock
{
    public class MockProjectsRepository : IProjectsRepository
    {
        private readonly List<Project> _projects = new List<Project>();

        public Task<Project> AddAsync(Project item)
        {
            var projectWithId = item with { Id = _projects.Count + 1 };
            _projects.Add(projectWithId);

            return Task.Run(() => projectWithId);
        }

        public Task<int> DeleteAsync(long id)
        {
            var projectToDelete = _projects.First(p => p.Id == id);

            if (projectToDelete == null)
                throw new ApplicationException("No project found with id " + id);

            _projects.Remove(projectToDelete);

            return Task.Run(() => 1);
        }

        public Task<IEnumerable<Project>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Project item)
        {
            throw new NotImplementedException();
        }
    }
}
