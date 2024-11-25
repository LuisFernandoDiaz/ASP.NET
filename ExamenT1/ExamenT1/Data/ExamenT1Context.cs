using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamenT1.Models;

namespace ExamenT1.Data
{
    public class ExamenT1Context : DbContext
    {
        public ExamenT1Context (DbContextOptions<ExamenT1Context> options)
            : base(options)
        {
        }

        public DbSet<ExamenT1.Models.Ventas> Ventas { get; set; } = default!;
    }
}
