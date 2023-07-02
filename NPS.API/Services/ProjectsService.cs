using NPS.Api.Interfaces;
using NPS.Api.Models;
using NPS.Api.Repositories;
using System;
using System.Threading.Tasks;

namespace NPS.Api.Services
{
    internal class ProjectsService : BaseService<Project, IProjectsRepository>, IProjectsService
    { 
        private readonly IProjectsRepository _projectsRepository;

        public ProjectsService(IProjectsRepository projectsRepository) : base(projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }
    }

}