using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_Esquema.Model;

namespace Proyecto_Esquema.Data
{
    public class Proyecto_EsquemaContext : DbContext
    {
        public Proyecto_EsquemaContext (DbContextOptions<Proyecto_EsquemaContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto_Esquema.Model.Persona> Persona { get; set; } = default!;
    }
}
