using RegistroDeBiblias.BLL;
using RegistroDeBiblias.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeBiblias.UI.Registros
{
    public partial class RLibros : Form
    {
        public RLibros()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            SiglaTextBox.Text = string.Empty;
            TipoTextBox.Text = string.Empty;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Libros LlenarClase()
        {
            Libros libro = new Libros();
            libro.Id = Convert.ToInt32(IDnumericUpDown.Value);
            libro.Nombre = NombreTextBox.Text;
            libro.Descricion = DescripcionTextBox.Text;
            libro.Siglas = SiglaTextBox.Text;
            libro.Tipo = TipoTextBox.Text;
            return libro;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Libros libro;
         bool paso = false;

            libro = LlenarClase();
            if(IDnumericUpDown.Value == 0)
            {
                paso = LibrosBll.Guardar(libro);

                MessageBox.Show("Guardo");

            }
            else
            {
                MessageBox.Show("no guardo");
                }

        }
    }
}
