

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
            var project1 = await _projectsService.AddAsync(new Project() { Name="Project1"});
            var project2 = await _projectsService.AddAsync(new Project() { Name="Project2"});

            Assert.NotNull(project1);
            Assert.NotNull(project2);

            Assert.True(project2.Id > project1.Id);
            Assert.Equal("Project1", project1.Name);
            Assert.Equal("Project2", project2.Name);
        }

        [Fact]
        public async void GetAllProjects()
        {
            await _projectsService.AddAsync(new Project());
            await _projectsService.AddAsync(new Project());

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
            var projectToUpdate = await _projectsService.AddAsync(new Project());
            projectToUpdate.Name = "UpdatedProject";
            
            var rowsUpdated = await _projectsService.UpdateAsync(projectToUpdate);
            var updatedProject = await _projectsService.GetAsync(1);

            Assert.NotNull(updatedProject);
            Assert.Equal(1, rowsUpdated);
            Assert.Equal("UpdatedProject", updatedProject.Name);
        }
                    
        [Fact]      
        public async void DeleteOneProject()
        {
            var projectToDelete = await _projectsService.AddAsync(new Project());
            var rowsUpdated = await _projectsService.DeleteAsync(projectToDelete.Id);

            Assert.Equal(1, rowsUpdated);

            /* var project = ;
            Assert.Throws<NotFoundException>(() => await _projectsService.GetAsync(1)); */
        }
    }
}