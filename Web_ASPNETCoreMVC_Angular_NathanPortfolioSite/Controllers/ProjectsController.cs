using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPS.App.Interfaces;
using NPS.Logic.Interfaces;
using NPS.Logic.Models;
using NPS.Logic.Services;

namespace NPS.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    internal class ProjectsController : CRUDApiController<Project, IProjectsService>, ICRUDApiController<Project,ProjectsService>
    {
        private readonly IProjectsService _projectsService;

        public ProjectsController(IProjectsService projectsService) : base(projectsService)
        {
            _projectsService = projectsService;
        }
    }
}
