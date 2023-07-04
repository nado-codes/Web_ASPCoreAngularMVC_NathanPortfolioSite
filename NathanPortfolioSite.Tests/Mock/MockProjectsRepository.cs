using NPS.Api.Interfaces;
using NPS.Api.Models;
using NPS.Api.Repositories;
using NPS.API.Exceptions;
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
            if (item == null)
                throw new ArgumentException("item cannot be null");

            var projectWithId = item with { Id = _projects.Count + 1 };
            _projects.Add(projectWithId);

            return Task.Run(() => projectWithId);
        }

        public Task<int> DeleteAsync(long id)
        {
            var projectToDelete = _projects.FirstOrDefault(p => p.Id == id);

            if (projectToDelete == null)
                throw new NotFoundException("No project found with id " + id);

            _projects.Remove(projectToDelete);

            return Task.Run(() => 1);
        }

        public Task<IEnumerable<Project>> GetAllAsync()
        {
            return Task.Run<IEnumerable<Project>>(() => _projects);
        }

        public Task<Project> GetAsync(long id)
        {
            var project = _projects.FirstOrDefault(p => p.Id == id);

            if (project == null)
                throw new NotFoundException("No project found with id " + id);

            return Task.Run(() => project);
        }

        public Task<int> UpdateAsync(Project item)
        {
            if (item == null)
                throw new ArgumentException("item cannot be null");

            var oldProject = _projects.FirstOrDefault(p => p.Id == item.Id);

            if (oldProject == null)
                throw new NotFoundException("No project found with id " + item.Id);

            _projects.Add(item);
            _projects.Remove(oldProject);

            return Task.Run(() => 1);
        }
    }
}
