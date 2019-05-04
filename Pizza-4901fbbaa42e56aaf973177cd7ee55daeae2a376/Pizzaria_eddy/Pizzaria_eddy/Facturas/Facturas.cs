using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_eddy.Facturas
{
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {

        }

        private void Facturas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            new pizza().Show();
        }
    }
}
