
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace naveen.Model
{
    public class ApplicationDbContext:DbContext
    {
           public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<book> book{ get; set; }
    }
}
