using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooAnimalList.Models;

namespace ZooAnimalList.Data
{
    public class ZooPriceContext : DbContext
    {
        public ZooPriceContext (DbContextOptions<ZooPriceContext> options)
            : base(options)
        {
        }

        public DbSet<ZooAnimalList.Models.Price> Price { get; set; } = default!;
    }
}
