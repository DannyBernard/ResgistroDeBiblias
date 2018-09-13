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
        public DbSet<Libros> libros { set; get; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
