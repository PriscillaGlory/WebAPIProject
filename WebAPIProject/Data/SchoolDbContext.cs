using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIProject.Models.Marks> Marks { get; set; } = default!;

        public DbSet<WebAPIProject.Models.Students>? Students { get; set; }

        public DbSet<WebAPIProject.Models.Subjects>? Subjects { get; set; }
    }
}
