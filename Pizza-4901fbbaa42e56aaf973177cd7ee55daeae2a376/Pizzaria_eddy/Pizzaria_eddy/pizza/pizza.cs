using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_eddy
{
    public partial class pizza : Form
    {
        public pizza()
        {
            InitializeComponent();
        }

        private void pizza_Load(object sender, EventArgs e)
        {

        }

        private void pizza_FormClosing(object sender, FormClosingEventArgs e)
        {
            new inicio().Show();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPizza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ordenar.ordenar Objeto = new Ordenar.ordenar();
            Objeto.Show();
        }

        private void buttonFacturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas.Ventas Objeto = new Ventas.Ventas();
            Objeto.Show();
        }
    }
}
