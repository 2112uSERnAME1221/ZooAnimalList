using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooAnimalList.Models;

namespace ZooAnimalList.Data
{
    public class ZooAnimalListContext : DbContext
    {
        public ZooAnimalListContext (DbContextOptions<ZooAnimalListContext> options)
            : base(options)
        {
        }

        public DbSet<ZooAnimalList.Models.AnimalListInfo> AnimalListInfo { get; set; } = default!;
    }
}
