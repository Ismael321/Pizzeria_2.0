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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ordenar.ordenar().Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
