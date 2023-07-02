using NPS.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Api.Repositories
{
    public class ProjectsDummyRepository : ProjectsRepository
    {
        public override Task<IEnumerable<Project>> GetAllAsync()
        {
            return Task.Run<IEnumerable<Project>>(() => new List<Project>()
            {
                new Project() { Id = 1, Name = "BakerBest", ImageUrl="https://i.imgur.com/g2eHzNa.jpg" },
                new Project() { Id = 2, Name = "RediRide", ImageUrl="https://i.imgur.com/DCguhen.jpg" },
                new Project() { Id = 3, Name = "Haven : Unbound", ImageUrl="https://i.imgur.com/8he65uH.png" },
            });
        }
    }
}
