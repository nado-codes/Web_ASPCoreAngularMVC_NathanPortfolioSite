using Microsoft.EntityFrameworkCore;
using NPS.Api.Models;

namespace NPS.API.Interfaces
{
    public interface INpsDbContext
    {
        public DbSet<Project> Projects { get; set; }
    }
}
