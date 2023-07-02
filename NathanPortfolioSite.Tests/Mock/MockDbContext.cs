using Microsoft.EntityFrameworkCore;
using NPS.Api.Models;
using NPS.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.Tests.Mock
{
    internal class MockDbContext : DbContext, INpsDbContext
    {
        public MockDbContext(DbContextOptions<MockDbContext> options) { }

        public DbSet<Project> Projects { get; set; }
    }
}
