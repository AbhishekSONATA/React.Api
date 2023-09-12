using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace React.Api.Data.Entities
{
    public class ReactJSDemoContext : DbContext
    {
        public ReactJSDemoContext(DbContextOptions<ReactJSDemoContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<SuperVillain> SuperVillain { get; set; }

        public DbSet<Car> Car { get; set; }
    }
}
