using Entidadesdenegocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesoadatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; internal set; }
        public DbSet<Rol> Rol { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7QDEK088;Initial Catalog=pruebat21;Integrated Security=True");
        }
    }
}
