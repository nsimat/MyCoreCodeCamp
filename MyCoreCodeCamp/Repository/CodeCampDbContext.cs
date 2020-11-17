using Microsoft.EntityFrameworkCore;
using MyCoreCodeCamp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreCodeCamp.Repository
{
    public class CodeCampDbContext : DbContext
    {
        public CodeCampDbContext(DbContextOptions<CodeCampDbContext> options) : base(options)
        {

        }

        public DbSet<Camp> Camps { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
    }
}
