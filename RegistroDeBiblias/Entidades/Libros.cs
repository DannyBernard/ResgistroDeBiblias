using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeBiblias.Entidades
{
    class Libros
    {
        [Key]
        public int Id { set; get; } 
        public string Nombre { set; get; }
        public string Descricion { set; get; }
        public string Siglas { set; get; }
        public string Tipo { set; get; }

        public Libros()
        {
            Id = 0;
            Nombre = string.Empty;
            Descricion = string.Empty;
            Siglas = string.Empty;
            Tipo = string.Empty;
        }
    }
}
