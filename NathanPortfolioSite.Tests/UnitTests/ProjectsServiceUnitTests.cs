using NPS.Api.Interfaces;
using NPS.Tests.Mock;

namespace NPS.Tests.UnitTests
{
    public class ProjectsServiceUnitTests
    {
        private readonly IProjectsService _projectsService;

        public ProjectsServiceUnitTests()
        {
            var projectsRepository = new MockProjectsRepository();
        }
        [Fact]
        public async void AddTwoProjects()
        {

        }

        [Fact]
        public async void GetAllProjects()
        {       

        }

        [Fact]
        public async void GetOneProject()
        {

        }
                    
        [Fact]      
        public async void UpdateOneProject()
        {

        }
                    
        [Fact]      
        public async void DeleteOneProject()
        {

        }
    }
}