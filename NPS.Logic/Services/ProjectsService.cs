using NPS.Logic.Interfaces;
using NPS.Logic.Models;
using NPS.Logic.Repositories;
using System;
using System.Threading.Tasks;

namespace NPS.Logic.Services
{
    internal class ProjectsService : BaseService<Project,ProjectsRepository>, IProjectsService
    { 
        private readonly IProjectsRepository _projectsRepository;

        public ProjectsService(IProjectsRepository projectsRepository) : base(projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }
    }

}