using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Session02_b.Models;

namespace Session02_b.Data
{
    public class Session02_bContext : DbContext
    {
        public Session02_bContext (DbContextOptions<Session02_bContext> options)
            : base(options)
        {
        }

        public DbSet<Session02_b.Models.Ventas> Ventas { get; set; } = default!;
    }
}
