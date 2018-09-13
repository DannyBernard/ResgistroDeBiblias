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
        public string Descripcion { set; get; }
        public string Sigla { set; get; }
        public string Tipo { set; get; }

        public Libros()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Sigla = string.Empty;
            Tipo = string.Empty;
        }
    }
}
