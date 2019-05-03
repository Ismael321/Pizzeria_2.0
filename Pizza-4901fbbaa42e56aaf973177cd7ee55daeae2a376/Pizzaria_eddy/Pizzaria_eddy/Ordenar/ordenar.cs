using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_eddy.Ordenar
{
    public partial class ordenar : Form
    {
        public ordenar()
        {
            InitializeComponent();
        }

        private void ordenar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ordenar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new pizza().Show();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
