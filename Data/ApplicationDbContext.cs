using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using donet_tut_projects.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace donet_tut_projects.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}