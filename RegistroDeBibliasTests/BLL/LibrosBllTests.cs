using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroDeBiblias.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroDeBiblias.Entidades;

namespace RegistroDeBiblias.BLL.Tests
{
    [TestClass()]
    public class LibrosBllTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Libros libros = new Libros()
            {
                Id = 1,
                Nombre = "Genesis",
                Descricion = "primer libro",
                Siglas = "Gn",
                Tipo = "Historico"
            };
            bool paso = LibrosBll.Guardar(libros);
            Assert.AreEqual(paso, true);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Libros libros = new Libros()
            {
                Id = 1,
                Nombre = "Genesis",
                Descricion = "primer libro",
                Siglas = "Gn",
                Tipo = "Historico"
            };
            
            bool paso = LibrosBll.Eliminar(2);
            Assert.AreEqual(paso, true);
        }
    }
}