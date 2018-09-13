using RegistroDeBiblias.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeBiblias.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Libros> Libros { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
