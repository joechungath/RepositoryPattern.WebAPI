using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public  class AppContext:DbContext
    {
        public AppContext(DbContextOptions<AppContext> options):base(options)
        {

        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }    
    }
}
