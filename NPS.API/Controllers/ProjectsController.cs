using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPS.App.Interfaces;
using NPS.Api.Interfaces;
using NPS.Api.Models;
using NPS.Api.Services;

namespace NPS.App.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : CRUDApiController<Project, IProjectsService>, ICRUDApiController<Project,ProjectsService>
    {
        private readonly IProjectsService _projectsService;

        public ProjectsController(IProjectsService projectsService) : base(projectsService)
        {
            _projectsService = projectsService;
        }
    }
}
