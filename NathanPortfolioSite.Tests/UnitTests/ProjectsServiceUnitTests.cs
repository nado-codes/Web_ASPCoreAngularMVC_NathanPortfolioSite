

using NPS.API.Exceptions;

namespace NPS.Tests.UnitTests
{
    public class ProjectsServiceUnitTests
    {
        private readonly IProjectsService _projectsService;

        public ProjectsServiceUnitTests()
        {
            var projectsRepo = new MockProjectsRepository();
            _projectsService = new ProjectsService(projectsRepo);
        }

        [Fact]
        public async void AddTwoProjects()
        {
            var project1 = await _projectsService.AddAsync(new Project());
            var project2 = await _projectsService.AddAsync(new Project());

            Assert.NotNull(project1);
            Assert.NotNull(project2);
        }

        [Fact]
        public async void GetAllProjects()
        {       
            var projects = await _projectsService.GetAllAsync();
            Assert.NotEmpty(projects);
            Assert.Equal(2, projects.Count());
        }

        [Fact]
        public async void GetOneProject()
        {
            var project = await _projectsService.GetAsync(1);
            Assert.NotNull(project);
        }
                    
        [Fact]      
        public async void UpdateOneProject()
        {
            var project = await _projectsService.GetAsync(1);
            project.Name = "UpdatedProject";
            
            var rowsUpdated = await _projectsService.UpdateAsync(project);
            var updatedProject = await _projectsService.GetAsync(1);

            Assert.NotNull(updatedProject);
            Assert.Equal(1, rowsUpdated);
            Assert.Equal("UpdatedProject", updatedProject.Name);
        }
                    
        [Fact]      
        public async void DeleteOneProject()
        {
            var rowsUpdated = await _projectsService.DeleteAsync(1);

            Assert.Equal(1, rowsUpdated);

            /* var project = ;
            Assert.Throws<NotFoundException>(() => await _projectsService.GetAsync(1)); */
        }
    }
}