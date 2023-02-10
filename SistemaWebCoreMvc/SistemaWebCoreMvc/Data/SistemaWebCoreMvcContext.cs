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

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Venda> Venda { get; set; }
    }
}
