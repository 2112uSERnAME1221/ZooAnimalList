using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooAnimalList.Models;

namespace ZooAnimalList.Data
{
    public class ZooEventAndScheduleContext : DbContext
    {
        public ZooEventAndScheduleContext (DbContextOptions<ZooEventAndScheduleContext> options)
            : base(options)
        {
        }

        public DbSet<ZooAnimalList.Models.Event> Event { get; set; } = default!;
    }
}
