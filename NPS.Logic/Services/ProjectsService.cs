using NPS.Logic.Interfaces;
using NPS.Logic.Models;
using NPS.Logic.Repositories;
using System;
using System.Threading.Tasks;

namespace NPS.Logic.Services
{
    internal class ProjectsService : BaseService<Project, IProjectsRepository>, IProjectsService
    { 
        private readonly IProjectsRepository _projectsRepository;

        public ProjectsService(IProjectsRepository projectsRepository) : base(projectsRepository)
        {
            _projectsRepository = projectsRepository;
        }

        public new IEnumerable<Project> GetAll()
        {
            return new List<Project>()
            {
                new Project() { Id = 1, Name = "BakerBest", ImageUrl="https://i.imgur.com/g2eHzNa.jpg" },
                new Project() { Id = 2, Name = "RediRide", ImageUrl="https://i.imgur.com/DCguhen.jpg" },
                new Project() { Id = 3, Name = "Haven : Unbound", ImageUrl="https://i.imgur.com/8he65uH.png" },
            };
        }
    }

}