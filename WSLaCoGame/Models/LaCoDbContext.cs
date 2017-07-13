using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WSLaCoGame.Models
{
    public class LaCoDbContext:DbContext
    {
        public LaCoDbContext(DbContextOptions<LaCoDbContext> options)
            : base(options)
        {

        }
        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
