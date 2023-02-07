using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaWebCoreMvc.Models;

namespace SistemaWebCoreMvc.Data
{
    public class SistemaWebCoreMvcContext : DbContext
    {
        public SistemaWebCoreMvcContext (DbContextOptions<SistemaWebCoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaWebCoreMvc.Models.Departamento> Departamento { get; set; } = default!;
    }
}
