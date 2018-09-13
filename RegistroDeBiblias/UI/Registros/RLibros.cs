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

        private bool Validar()
             {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(TipoTextBox.Text))
            {
                errorProvider1.SetError(TipoTextBox, "Campo esta vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(SiglaTextBox.Text))
            {
                errorProvider1.SetError(SiglaTextBox, "Campo esta vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                errorProvider1.SetError(DescripcionTextBox, "Campo esta vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Campo esta vacio");
                paso = false;
            }
            

            return paso;
 }
        private bool EstaEnBaseDatos()
        {
            Libros libros = LibrosBll.Buscar((int)IDnumericUpDown.Value);
            return (libros != null);
        }

        private void LlenarCampo(Libros libros)
        {

            IDnumericUpDown.Value = libros.Id;
            NombreTextBox.Text = libros.Nombre;
            DescripcionTextBox.Text = libros.Descricion;
            SiglaTextBox.Text = libros.Siglas;
            TipoTextBox.Text = libros.Tipo;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
          errorProvider1.Clear();
            Libros libro;
         bool paso = false;

            if (!Validar())
               return;

            libro = LlenarClase();

            if (IDnumericUpDown.Value == 0)

                paso = LibrosBll.Guardar(libro);
            else
            {
                if (!EstaEnBaseDatos())
                {
                    MessageBox.Show(" no ha sido modificado");
                    return;
                }

                paso = LibrosBll.Modificar(libro);
               

            }
            Limpiar();

            if (paso) 
                MessageBox.Show("Guardo","Imfornacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
            
                MessageBox.Show("no guardo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
              }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            if (LibrosBll.Eliminar(id))
            {
                MessageBox.Show("Eliminado con Exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo Guardar");
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Libros libros = new Libros();
            int.TryParse(IDnumericUpDown.Text, out id);

            libros = LibrosBll.Buscar(id);

            if(libros != null)
            {
                LlenarCampo(libros);
                MessageBox.Show("Libro Encotrado");

            }
            else
            {
                MessageBox.Show("Libro no Exite");
            }


        }
    }
}
