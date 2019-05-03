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
    public partial class Admin : Form
    {
        string objetoQuery = "Select * from Empleados";
        Conexion.Conexion ObjetoConexion = new Conexion.Conexion();
        bool Actualizar = false;
        ToolTip Descripcion = new ToolTip();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Informacion();
            Actualizar = false;
            String Tabla = "Empleados";
            ObjetoConexion.ActualizarGrid(DataGridEmpleados, objetoQuery, Tabla);
        }
        #region Eventos Button/TextBox
        void LimpiarTextBox()
        {
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            txtID.Text = "";
            txtTelefono.Text = "";
            txtCurp.Text = "";
            txtNSS.Text = "";
            txtSalario.Text = "0";
        }
        void Informacion()
        {
            Descripcion.SetToolTip(buttonGuardar, "Guardar Registro");
            Descripcion.SetToolTip(buttonNuevo, "Nuevo registro");
            Descripcion.SetToolTip(buttonActualizar, "Modificar Registro");
            Descripcion.SetToolTip(buttonRegresar, "Regresar");
        }
        #endregion
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            new inicio().Show();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string tablaE = "Empleados";
            ObjetoConexion.ActualizarGrid(this.DataGridEmpleados, "select * from Empleados where Nombre like'" + txtBuscar.Text + "%';", tablaE);

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (Actualizar == true)
            {
                String Tabla = "Empleados";
                ObjetoConexion.Abrir_coneccion();

                String Query = "update Empleados set Nombre ='" + txtNombre.Text + "', Apellido_Paterno ='" + txtApellidoP.Text + "', Apellido_Materno = '" + txtApellidoM.Text + "', Telefono = " + txtTelefono.Text + ", CURP = '" + txtCurp.Text + "', NSS = " + txtNSS.Text + ", Salario = " + txtSalario.Text + " where Id_Empleado = " + txtID.Text + ";";
                ObjetoConexion.EjecutarSql(Query);

                ObjetoConexion.ActualizarGrid(this.DataGridEmpleados, objetoQuery, Tabla);

                ObjetoConexion.Cerrar_Coneccion();

                Actualizar = false;
                LimpiarTextBox();
            }
            else
            {
                if (txtNombre.Text.Trim().ToString().Equals("")) { MessageBox.Show("Llene Campo Nombre"); return; }
                else if (txtApellidoP.Text.Trim().ToString().Equals("")) { MessageBox.Show("LLene Campo Apellido Paterno"); return; }
                else if (txtApellidoM.Text.Trim().ToString().Equals("")) { MessageBox.Show("LLene Campo Apellido Materno"); return; }
                else if (txtTelefono.Text.Trim().ToString().Equals("")) { MessageBox.Show("LLene Campo Telefono"); return; }
                else if (txtCurp.Text.Trim().ToString().Equals("")) { MessageBox.Show("LLene Campo CURP"); return; }
                else if (txtNSS.Text.Trim().ToString().Equals("")) { MessageBox.Show("LLene Campo NSS"); return; }
                else if (txtSalario.Text.Trim().ToString().Equals("")) { MessageBox.Show("LLene Campo Salario"); return; }
                else
                {
                    if (txtSalario.Text.Trim().ToString().Equals("0")) { MessageBox.Show("Salario no Asignado, Valor por Default '0'"); }
                    String Tabla = "Empleados";
                    ObjetoConexion.Abrir_coneccion();
                    String Query = "insert into Empleados (Nombre, Apellido_Paterno, Apellido_Materno, Telefono, CURP, NSS, Salario, Fecha_Ingreso) values ('" + txtNombre.Text + "','" + txtApellidoP.Text + "','" + txtApellidoM.Text + "'," + txtTelefono.Text + ",'" + txtCurp.Text + "','" + txtNSS.Text + "'," + txtSalario.Text + ",'" + this.dateTimePicker1.Text + "');";
                    ObjetoConexion.EjecutarSql(Query);
                    ObjetoConexion.ActualizarGrid(this.DataGridEmpleados, objetoQuery, Tabla);

                    ObjetoConexion.Cerrar_Coneccion();
                    LimpiarTextBox();
                    txtID.Enabled = false;
                }

            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            string tablaE = "Empleados";
            ObjetoConexion.ActualizarGrid(DataGridEmpleados, objetoQuery, tablaE);
            LimpiarTextBox();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Actualizar = true;
            //Capturar los datos de la DataGrid y asignarlos a las cajas de texto       
            txtID.Text = this.DataGridEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtNombre.Text = this.DataGridEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtApellidoP.Text = this.DataGridEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellidoM.Text = this.DataGridEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = this.DataGridEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtCurp.Text = this.DataGridEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtNSS.Text = this.DataGridEmpleados.CurrentRow.Cells[6].Value.ToString();
            txtSalario.Text = this.DataGridEmpleados.CurrentRow.Cells[7].Value.ToString();
            // txtID.Enabled = false;
        }
        private bool DetectarFormularioAbierto(String Formulario)
        {
            bool abierto = false;
            if (Application.OpenForms[Formulario] != null)
            {
                abierto = true;
                Application.OpenForms[Formulario].Activate();
                Application.OpenForms[Formulario].WindowState = FormWindowState.Maximized;
            }
            return abierto;
        }
        #region Validaciones txtBox
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gerente.SlnGerente.SoloLetras(e);
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gerente.SlnGerente.SoloLetras(e);
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gerente.SlnGerente.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gerente.SlnGerente.SoloNumeros(e);
        }

        private void txtNSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gerente.SlnGerente.SoloNumeros(e);
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gerente.SlnGerente.SoloNumeros(e);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Gerente.SlnGerente.SoloLetras(e);
        }
        #endregion
    }
}
