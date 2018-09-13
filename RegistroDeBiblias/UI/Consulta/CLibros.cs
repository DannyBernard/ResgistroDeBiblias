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

namespace RegistroDeBiblias.UI.Consulta
{
    public partial class CLibros : Form
    {
        public CLibros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listado = new List<Libros>();
         if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (ComboComboBox.SelectedItem)
                {
                    case 0://todo
                        listado = LibrosBll.GetList(p => true);
                        break;
                    case 1://id
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = LibrosBll.GetList(p => p.Id == id);
                        break;
                   case 2://nombre
                        listado = LibrosBll.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;
                    case 3://descricipcion
                        listado = LibrosBll.GetList(p => p.Descricion.Contains(CriterioTextBox.Text));
                        break;
                    case 4://sigla
                        listado = LibrosBll.GetList(p => p.Siglas.Contains(CriterioTextBox.Text));
                        break;
                    case 5://tipo
                        listado = LibrosBll.GetList(p => p.Tipo.Contains(CriterioTextBox.Text));
                        break;
                }
               // listado = listado.Where(c => c.)
            }
            else
            {
                listado = LibrosBll.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;

        }
    }
}
