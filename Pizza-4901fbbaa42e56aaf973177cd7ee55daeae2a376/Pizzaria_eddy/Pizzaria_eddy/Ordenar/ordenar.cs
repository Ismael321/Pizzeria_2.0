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
        ToolTip Informacion = new ToolTip();
        Conexion.Conexion ObjetoConexion = new Conexion.Conexion();
        private void ordenar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Descripcion();
            EnabledBox();

            SaborCBX.Enabled = false;
            TamanoCBX.Enabled = false;
            CantidadCBX.Enabled = false;
        }

        void EnabledBox()
        {
            Ingrediente1CBX.Enabled = false; Ingrediente2CBX.Enabled = false; Ingrediente3CBX.Enabled = false;
            Ingrediente4CBX.Enabled = false;
            DesHabilitarDom();
        }
        private void ordenar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new pizza().Show();
        }
        #region Registro DB
        void Registrar()
        {
            ObjetoConexion.Abrir_coneccion();
            String Tipo = Convert.ToString(TipoCBX.SelectedItem).Trim();
            if (TipoCBX.Text.ToString() == "Perzonalizada") { Tipo = "Perzonalizada"; }
            String PizzaTam = Convert.ToString(Box_tamano.SelectedItem).Trim(); String Ing1 = Convert.ToString(Ingrediente1CBX.Text).Trim();
            String Ing2 = Convert.ToString(Ingrediente2CBX.Text).Trim(); String Ing3 = Convert.ToString(Ingrediente3CBX.Text).Trim(); String Ing4 = Convert.ToString(Ingrediente4CBX.Text).Trim();
            String SBfresco = Convert.ToString(SaborCBX.SelectedItem).Trim(); String TamRefresco = Convert.ToString(TamanoCBX.SelectedItem).Trim(); String CantidadR = Convert.ToString(CantidadCBX.SelectedItem).Trim();
            if (Si_radiobutton.Checked == true)
            {
                String Query = "insert into Pedidos (TipoPizza, TamanoPizza, Ingrediente1, Ingrediente2, Ingrediente3, Ingrediente4, SaborRefresco, TamanoRefresco, CantidadRefresco) values ('" + Tipo + "','" + PizzaTam + "','" + Ing1 + "','" + Ing2 + "','" + Ing3 + "','" + Ing4 + "','" + SBfresco + "','" + TamRefresco + "'," + CantidadR + ");";
                ObjetoConexion.EjecutarSql(Query);
            }
            else if(No_radiobutton.Checked == true)
            {
                String Query = "insert into Pedidos (TipoPizza, TamanoPizza, Ingrediente1, Ingrediente2, Ingrediente3, Ingrediente4) values ('" + Tipo + "','" + PizzaTam + "','" + Ing1 + "','" + Ing2 + "','" + Ing3 + "','" + Ing4 + "');";
                ObjetoConexion.EjecutarSql(Query);
            }
            else
            {
                MessageBox.Show("Ah ocurrido un error, Numero de Error O68");return;
            }
            ObjetoConexion.Cerrar_Coneccion();
        }
        #endregion
        #region Registro Factura
        void RFactura()
        {
            String Nombre = txtNombre.Text.Trim(); String Domicilio = txtDomicilio.Text.Trim(); String Numero = txtNumero.Text.Trim();
            String Calle1 = txtCalle.Text.Trim(); String Calle2 = txtCalle2.Text.Trim(); String Comentarios = richtextComentario.Text.Trim();
            int PTotal = Convert.ToInt32(this.txtxCostoTotal.Text); 
            if (Si_RadioButton2.Checked == true )
            {
                Ordenar.slnOrdenar.RegsitroFacturaDom(Nombre,Domicilio, Numero, Calle1, Calle2,Comentarios, PTotal);
            }
            else if(No_RadioButton2.Checked == true)
            {
                Ordenar.slnOrdenar.RegistroFacturas(Nombre, PTotal);
            }
            else { MessageBox.Show("Algo salio Mal, Numero de Error 'O-87' ");return; }
        } 
        #endregion
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (Box_tamano.Text.Trim().ToString().Equals("Seleccione Una Opcion")) {MessageBox.Show("Tamaño de Pizza no Seleccionada"); return; }
            else if (IngredientesCBX.Text.Trim().ToString().Equals("0")) { MessageBox.Show("Ingredientes no seleccionados, Elija 1"); return; }
            else if (SaborCBX.Text.Trim().ToString().Equals("Sabor")) { MessageBox.Show("Apartado Refresco: Sabor no Seleccionado"); return; }
            else if (TamanoCBX.Text.Trim().ToString().Equals("Tamaño")) { MessageBox.Show("Apartado Refresco: Tamaño no Seleccionado"); return; }
            else if (CantidadCBX.Text.Trim().ToString().Equals("0")) { MessageBox.Show("Apartado Refresco: Cantidad '0' Asigne Valor"); return; }
            else if (txtNombre.Text.Trim().ToString().Equals("")) {MessageBox.Show("Ingrese Nombre del Cliente"); return;}
            else if (txtxCostoTotal.Text.Trim().ToString().Equals("0")) { MessageBox.Show("No existe Orden a facturar, saldo en '0'"); return; }
            else
            {
                DialogResult Resultado;
                Resultado = MessageBox.Show("Orden finalizada ¿Todos los datos estan correctos?","Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == DialogResult.Yes)
                {
                    Registrar();
                    RFactura();
                    Facturas.Facturas Objeto = new Facturas.Facturas();
                    Objeto.Show();
                    this.Close();
                }
                else
                { MessageBox.Show("          Orden no Generada, Cheque el pedido             "); }
            }
        }
        #region Limpiar Cajas
        void LimpiarCajas()
        {
            IngredientesCBX.Enabled = true;
            TipoCBX.Text = "Seleccione Una Opcion";
            Box_tamano.Text = "Seleccione Una Opcion";
            IngredientesCBX.Text = "0";
            Ingrediente1CBX.Text = "";
            Ingrediente2CBX.Text = "";
            Ingrediente3CBX.Text = "";
            Ingrediente4CBX.Text = "";
            SaborCBX.Text = "Sabor";
            TamanoCBX.Text = "Tamaño";
            CantidadCBX.Text = "0";
            txtTotal.Text = "0";
            txtRefrescos.Text = "0";
            txtxCostoTotal.Text = "0";
            txtNombre.Text = "";
            No_radiobutton.AutoCheck = true;
            DesHabilitarDom();
        }
        #endregion

        private void IngredientesCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aux1 = 0; int aux2 = 0; int SumaAux = 0;
            if(IngredientesCBX.SelectedItem.ToString() == "1")
            {
                txtTotal.Text = "0";
                Ingrediente1CBX.Enabled = true;
                Ingrediente2CBX.Enabled = false;
                Ingrediente3CBX.Enabled = false;
                Ingrediente4CBX.Enabled = false;
                Ingrediente2CBX.Text = "No Disponible";
                Ingrediente3CBX.Text = "No Disponible";
                Ingrediente4CBX.Text = "No Disponible";
                aux1 = 80 + (1 * 10);
                aux2 = Convert.ToInt32(this.txtTotal.Text);
                SumaAux = aux1 + aux2;
                txtTotal.Text = SumaAux.ToString();
            }
            else if (IngredientesCBX.SelectedItem.ToString() == "2")
            {
                txtTotal.Text = "0";
                Ingrediente1CBX.Enabled = true;
                Ingrediente2CBX.Enabled = true;
                Ingrediente3CBX.Enabled = false;
                Ingrediente4CBX.Enabled = false;
                Ingrediente2CBX.Text = "";
                Ingrediente3CBX.Text = "No Disponible";
                Ingrediente4CBX.Text = "No Disponible";
                aux1 = 80 + (2 * 10);
                aux2 = Convert.ToInt32(this.txtTotal.Text);
                SumaAux = aux1 + aux2;
                txtTotal.Text = SumaAux.ToString();
            }
            else if (IngredientesCBX.SelectedItem.ToString() == "3")
            {
                txtTotal.Text = "0";
                Ingrediente1CBX.Enabled = true;
                Ingrediente2CBX.Enabled = true;
                Ingrediente3CBX.Enabled = true;
                Ingrediente4CBX.Enabled = false;
                Ingrediente2CBX.Text = "";
                Ingrediente3CBX.Text = "";
                Ingrediente4CBX.Text = "No Disponible";
                aux1 = 80 + (3 * 10);
                aux2 = Convert.ToInt32(this.txtTotal.Text);
                SumaAux = aux1 + aux2;
                txtTotal.Text = SumaAux.ToString();
            }
            else if (IngredientesCBX.SelectedItem.ToString() == "4")
            {
                txtTotal.Text = "0";
                Ingrediente1CBX.Enabled = true;
                Ingrediente2CBX.Enabled = true;
                Ingrediente3CBX.Enabled = true;
                Ingrediente4CBX.Enabled = true;
                Ingrediente2CBX.Text = "";
                Ingrediente3CBX.Text = "";
                Ingrediente4CBX.Text = "";
                aux1 = 80 + (4 * 10);
                aux2 = Convert.ToInt32(this.txtTotal.Text);
                SumaAux = aux1 + aux2;
                txtTotal.Text = SumaAux.ToString();
            }
        }
        #region Informacion
        void Descripcion()
        {
            Informacion.SetToolTip(this.buttonConfirmar, "Confirmar Solicitud");
            Informacion.SetToolTip(this.buttonCancelar,"Cancelar Pedido");
            Informacion.SetToolTip(this.buttonRegresar,"Regresar");
            Informacion.SetToolTip(this.buttonAyuda, "Datos de la Seleccion de tipo de Pizza");
            Informacion.SetToolTip(this.buttonPersonalizar,"Pizza Personalizada");
        }

        #endregion
        #region Validacion combobox
        private void IngredientesCBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Box_tamano_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Ingrediente1CBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Ingrediente2CBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Ingrediente3CBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SaborCBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TamanoCBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CantidadCBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Ingrediente4CBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtxCostoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtRefrescos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TipoCBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Si_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(Si_radiobutton.AutoCheck == true)
            {
                SaborCBX.Enabled = true;
                TamanoCBX.Enabled = true;
                CantidadCBX.Enabled = true;
            }         
        }

        private void No_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(No_radiobutton.AutoCheck == true)
            {
                SaborCBX.Enabled = false;
                TamanoCBX.Enabled = false;
                CantidadCBX.Enabled = false;
                SaborCBX.Text = "";
                TamanoCBX.Text = "";
                CantidadCBX.Text = "";
            }
        }
        #endregion
        #region Validar Letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ordenar.slnOrdenar.SoloLetras(e);
        }
        #endregion

        private void TipoCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Total = 0;
            if(TipoCBX.SelectedItem.ToString() == "Hawaiana")
            {
                EnabledBox();
                IngredientesCBX.Enabled = false;
                IngredientesCBX.Text = "";
                Ingrediente1CBX.Text = "Piña";
                Ingrediente2CBX.Text = "Jamon";
                Ingrediente3CBX.Text = "Mozzarella";
                Ingrediente4CBX.Text = "Salsa de Tomate";
                Total = Total + 79;
                txtTotal.Text = Total.ToString();
            }
            else if (TipoCBX.SelectedItem.ToString() == "Pepperoni")
            {
                EnabledBox();
                IngredientesCBX.Enabled = false;
                IngredientesCBX.Text = "";
                Ingrediente1CBX.Text = "Pepperoni";
                Ingrediente2CBX.Text = "Mozzarella";
                Ingrediente3CBX.Text = "Salami";
                Ingrediente4CBX.Text = "Salsa de Tomate";
                Total = Total + 89;
                txtTotal.Text = Total.ToString();
            }
            else if(TipoCBX.SelectedItem.ToString() == "Funghi")
            {
                EnabledBox();
                IngredientesCBX.Enabled = false;
                IngredientesCBX.Text = "";
                Ingrediente1CBX.Text = "Tomate";
                Ingrediente2CBX.Text = "Jamon";
                Ingrediente3CBX.Text = "Champiñones y Setas";
                Ingrediente4CBX.Text = "Mozzarella";
                Total = Total + 120;
                txtTotal.Text = Total.ToString();
            }
            else if (TipoCBX.SelectedItem.ToString() == "Vegetariana")
            {
                EnabledBox();
                IngredientesCBX.Enabled = false;
                IngredientesCBX.Text = "";
                Ingrediente1CBX.Text = "Pimientos";
                Ingrediente2CBX.Text = "Champiñones";
                Ingrediente3CBX.Text = "Aceitunas";
                Ingrediente4CBX.Text = "Mozzarella";
                Total = Total + 100;
                txtTotal.Text = Total.ToString();
            }
            else
            {
                MessageBox.Show("Ah ocurrido un error");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void buttonPersonalizar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            TipoCBX.Text = "Perzonalizada";
            TipoCBX.Enabled = true;
        }
        /*
      /////////////////Precios//////////////////
        Hawaiana    = $79 
        Pepperoni   = $89
        Funghi      = $120
        Vegetariana = $100
        
        Refrescos   Ch      M       Gr
        Coca-Cola   $9      $15     $28
        Manzanita   $9      $15     $28
        7Seven      $9      $15     $28
        Fanta       $9      $15     $28
        */
        #region Precio Chica
        void CostoTotalChica()
        {
            int Chica = 9; int aux1 = 0; int aux2 = 0; int SumaAux = 0;
             if (CantidadCBX.SelectedItem.ToString() == "1")
             {
                aux1 = (Chica * 2) - Chica;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
             }
             else if (CantidadCBX.SelectedItem.ToString() == "2")
            {
                aux1 = (Chica * 3) - Chica;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "3")
            {
                aux1 = (Chica * 4) - Chica;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "4")
            {
                aux1 = (Chica * 5) - Chica;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "5")
            {
                aux1 = (Chica * 6) - Chica;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
        }
        #endregion
        #region Mediana
        void CostoTotalMediana()
        {
            int Mediana = 15; int aux1 = 0; int aux2 = 0; int SumaAux = 0;
            if (CantidadCBX.SelectedItem.ToString() == "1")
            {
                aux1 = (Mediana * 2) - Mediana;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "2")
            {
                aux1 = (Mediana * 3) - Mediana;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "3")
            {
                aux1 = (Mediana * 4) - Mediana;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "4")
            {
                aux1 = (Mediana * 5) - Mediana;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "5")
            {
                aux1 = (Mediana * 6) - Mediana;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
        }
        #endregion
        #region Grande
        void CostoTotalGrande()
        {
            int Grande = 28; int aux1 = 0; int aux2 = 0; int SumaAux = 0;
            if (CantidadCBX.SelectedItem.ToString() == "1")
            {
                aux1 = (Grande * 2) - Grande;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "2")
            {
                aux1 = (Grande * 3) - Grande;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "3")
            {
                aux1 = (Grande * 4) - Grande;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "4")
            {
                aux1 = (Grande * 5) - Grande;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
            else if (CantidadCBX.SelectedItem.ToString() == "5")
            {
                aux1 = (Grande * 6) - Grande;
                aux2 = Convert.ToInt32(this.txtRefrescos.Text);
                SumaAux = aux1 + aux2;
                txtRefrescos.Text = SumaAux.ToString();
            }
        }
        #endregion
        private void CantidadCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TamanoCBX.Text.Trim().ToString().Equals("Tamaño"))
            {
                MessageBox.Show("LLene el Campo de Tamaño de Refresco"); return;
            }
            else if (TamanoCBX.Text.Trim().ToString().Equals("Sabor"))
            {
                MessageBox.Show("LLene el Campo de Tipo de Refresco"); return;
            }
            else if (TamanoCBX.SelectedItem.ToString() == "Chica 355ml")
            {
                txtRefrescos.Text = "0";
                CostoTotalChica();
            }
            else if (TamanoCBX.SelectedItem.ToString() == "Mediana 500ml")
            {
                txtRefrescos.Text = "0";
                CostoTotalMediana();
            }
            else if (TamanoCBX.SelectedItem.ToString() == "Grande 2.5lts")
            {
                txtRefrescos.Text = "0";
                CostoTotalGrande();
            }
        }
        private void txtxCostoTotal_Enter(object sender, EventArgs e)
        {
            int Total = 0;
            Total = int.Parse(txtTotal.Text) + int.Parse(txtRefrescos.Text);
            txtxCostoTotal.Text = Total.ToString();
        }
        void DesHabilitarDom()
        {
            txtDomicilio.Enabled = false; txtDomicilio.Text = ""; txtNumero.Enabled = false; txtNumero.Text = "";
            txtCalle.Enabled = false; txtCalle.Text = ""; txtCalle2.Enabled = false; txtCalle2.Text = "";
            richtextComentario.Enabled = false; richtextComentario.Text = "";
            LabelDomicilio.Enabled = false; LabelNumero.Enabled = false; LabelCalle.Enabled = false;
            LabelY.Enabled = false; LabelComentarios.Enabled = false;
        }
        private void Si_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(Si_RadioButton2.AutoCheck == true)
            {
                txtDomicilio.Enabled = true; txtNumero.Enabled = true; txtCalle.Enabled = true; txtCalle2.Enabled = true;
                richtextComentario.Enabled = true;
                LabelDomicilio.Enabled = true; LabelNumero.Enabled = true; LabelCalle.Enabled = true;
                LabelY.Enabled = true; LabelComentarios.Enabled = true;
            }
        }

        private void No_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(No_RadioButton2.AutoCheck == true)
            {
                DesHabilitarDom();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
