using RegistroDeBiblias.UI.Consulta;
using RegistroDeBiblias.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeBiblias
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RLibros rl = new RLibros();
            rl.Show();

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLibros cl = new CLibros();
            cl.Show();
        }
    }
}
