namespace Pizzaria_eddy.Facturas
{
    partial class Facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Pizza = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.Lbl_revolucion = new System.Windows.Forms.Label();
            this.GB_factura = new System.Windows.Forms.GroupBox();
            this.txtNFactura = new System.Windows.Forms.TextBox();
            this.lbl_factura = new System.Windows.Forms.Label();
            this.gb_Fecha = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaFactura = new System.Windows.Forms.Label();
            this.gb_DatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.Cb_total = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.TB_importeLetra = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_importeLetra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_factura.SuspendLayout();
            this.gb_Fecha.SuspendLayout();
            this.gb_DatosUsuario.SuspendLayout();
            this.Cb_total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 162);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LB_Pizza
            // 
            this.LB_Pizza.AutoSize = true;
            this.LB_Pizza.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Pizza.Location = new System.Drawing.Point(414, 22);
            this.LB_Pizza.Name = "LB_Pizza";
            this.LB_Pizza.Size = new System.Drawing.Size(181, 19);
            this.LB_Pizza.TabIndex = 1;
            this.LB_Pizza.Text = "Pizza Eddy\'s S.A. DE C.V";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rfc.Location = new System.Drawing.Point(414, 41);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(156, 19);
            this.lbl_rfc.TabIndex = 2;
            this.lbl_rfc.Text = "R.F.C.  5456 5456 546";
            // 
            // Lbl_revolucion
            // 
            this.Lbl_revolucion.AutoSize = true;
            this.Lbl_revolucion.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_revolucion.Location = new System.Drawing.Point(414, 60);
            this.Lbl_revolucion.Name = "Lbl_revolucion";
            this.Lbl_revolucion.Size = new System.Drawing.Size(145, 19);
            this.Lbl_revolucion.TabIndex = 3;
            this.Lbl_revolucion.Text = "Av. Revolucion #487";
            // 
            // GB_factura
            // 
            this.GB_factura.Controls.Add(this.txtNFactura);
            this.GB_factura.Controls.Add(this.lbl_factura);
            this.GB_factura.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_factura.Location = new System.Drawing.Point(831, 31);
            this.GB_factura.Name = "GB_factura";
            this.GB_factura.Size = new System.Drawing.Size(184, 98);
            this.GB_factura.TabIndex = 4;
            this.GB_factura.TabStop = false;
            // 
            // txtNFactura
            // 
            this.txtNFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNFactura.Location = new System.Drawing.Point(10, 53);
            this.txtNFactura.Name = "txtNFactura";
            this.txtNFactura.Size = new System.Drawing.Size(144, 19);
            this.txtNFactura.TabIndex = 1;
            // 
            // lbl_factura
            // 
            this.lbl_factura.AutoSize = true;
            this.lbl_factura.Location = new System.Drawing.Point(6, 19);
            this.lbl_factura.Name = "lbl_factura";
            this.lbl_factura.Size = new System.Drawing.Size(91, 19);
            this.lbl_factura.TabIndex = 0;
            this.lbl_factura.Text = "No. Factura";
            // 
            // gb_Fecha
            // 
            this.gb_Fecha.Controls.Add(this.dateTimePicker1);
            this.gb_Fecha.Controls.Add(this.lbl_fechaFactura);
            this.gb_Fecha.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Fecha.Location = new System.Drawing.Point(831, 135);
            this.gb_Fecha.Name = "gb_Fecha";
            this.gb_Fecha.Size = new System.Drawing.Size(184, 91);
            this.gb_Fecha.TabIndex = 5;
            this.gb_Fecha.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_fechaFactura
            // 
            this.lbl_fechaFactura.AutoSize = true;
            this.lbl_fechaFactura.Location = new System.Drawing.Point(6, 22);
            this.lbl_fechaFactura.Name = "lbl_fechaFactura";
            this.lbl_fechaFactura.Size = new System.Drawing.Size(51, 19);
            this.lbl_fechaFactura.TabIndex = 1;
            this.lbl_fechaFactura.Text = "Fecha";
            // 
            // gb_DatosUsuario
            // 
            this.gb_DatosUsuario.Controls.Add(this.txtCliente);
            this.gb_DatosUsuario.Controls.Add(this.lbl_cliente);
            this.gb_DatosUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_DatosUsuario.Location = new System.Drawing.Point(12, 222);
            this.gb_DatosUsuario.Name = "gb_DatosUsuario";
            this.gb_DatosUsuario.Size = new System.Drawing.Size(1003, 59);
            this.gb_DatosUsuario.TabIndex = 6;
            this.gb_DatosUsuario.TabStop = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Location = new System.Drawing.Point(75, 22);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(292, 19);
            this.txtCliente.TabIndex = 2;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(6, 22);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(63, 19);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // Cb_total
            // 
            this.Cb_total.Controls.Add(this.txtTotal);
            this.Cb_total.Controls.Add(this.TB_importeLetra);
            this.Cb_total.Controls.Add(this.lbl_Total);
            this.Cb_total.Controls.Add(this.lbl_importeLetra);
            this.Cb_total.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_total.Location = new System.Drawing.Point(12, 423);
            this.Cb_total.Name = "Cb_total";
            this.Cb_total.Size = new System.Drawing.Size(1003, 119);
            this.Cb_total.TabIndex = 8;
            this.Cb_total.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(661, 65);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(110, 19);
            this.txtTotal.TabIndex = 3;
            // 
            // TB_importeLetra
            // 
            this.TB_importeLetra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_importeLetra.Location = new System.Drawing.Point(6, 57);
            this.TB_importeLetra.Name = "TB_importeLetra";
            this.TB_importeLetra.Size = new System.Drawing.Size(342, 19);
            this.TB_importeLetra.TabIndex = 2;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(691, 87);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(44, 19);
            this.lbl_Total.TabIndex = 1;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_importeLetra
            // 
            this.lbl_importeLetra.AutoSize = true;
            this.lbl_importeLetra.Location = new System.Drawing.Point(6, 22);
            this.lbl_importeLetra.Name = "lbl_importeLetra";
            this.lbl_importeLetra.Size = new System.Drawing.Size(133, 19);
            this.lbl_importeLetra.TabIndex = 0;
            this.lbl_importeLetra.Text = "Importe Con Letra";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(939, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 567);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 60);
            this.dataGridView1.TabIndex = 10;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 683);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cb_total);
            this.Controls.Add(this.gb_DatosUsuario);
            this.Controls.Add(this.gb_Fecha);
            this.Controls.Add(this.GB_factura);
            this.Controls.Add(this.Lbl_revolucion);
            this.Controls.Add(this.lbl_rfc);
            this.Controls.Add(this.LB_Pizza);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Eddy\'s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facturas_FormClosed);
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_factura.ResumeLayout(false);
            this.GB_factura.PerformLayout();
            this.gb_Fecha.ResumeLayout(false);
            this.gb_Fecha.PerformLayout();
            this.gb_DatosUsuario.ResumeLayout(false);
            this.gb_DatosUsuario.PerformLayout();
            this.Cb_total.ResumeLayout(false);
            this.Cb_total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LB_Pizza;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.Label Lbl_revolucion;
        private System.Windows.Forms.GroupBox GB_factura;
        private System.Windows.Forms.TextBox txtNFactura;
        private System.Windows.Forms.Label lbl_factura;
        private System.Windows.Forms.GroupBox gb_Fecha;
        private System.Windows.Forms.Label lbl_fechaFactura;
        private System.Windows.Forms.GroupBox gb_DatosUsuario;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox Cb_total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox TB_importeLetra;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_importeLetra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}