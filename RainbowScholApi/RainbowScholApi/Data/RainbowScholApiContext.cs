using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowScholApi.Models;

namespace RainbowScholApi.Data
{
    public class RainbowScholApiContext : DbContext
    {
        public RainbowScholApiContext (DbContextOptions<RainbowScholApiContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowScholApi.Models.RainbowSchool> RainbowSchool { get; set; } = default!;
    }
}
