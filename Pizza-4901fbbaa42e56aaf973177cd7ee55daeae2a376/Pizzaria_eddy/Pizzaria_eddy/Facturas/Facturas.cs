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
        string objetoQuery = "select top(1) * from Factura order by IdFactura desc";
        public Facturas()
        {
            InitializeComponent();
        }
        private void Facturas_Load(object sender, EventArgs e)
        {
            Conexion.Conexion ObjetoConexion = new Conexion.Conexion();
            String Tabla = "Factura";            
            ObjetoConexion.ActualizarGrid(dataGridView1, objetoQuery, Tabla);
            txtCliente.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNFactura.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtTotal.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void Facturas_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ordenar.ordenar objeto = new Ordenar.ordenar();
            objeto.Show();
        }
        private void Facturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
