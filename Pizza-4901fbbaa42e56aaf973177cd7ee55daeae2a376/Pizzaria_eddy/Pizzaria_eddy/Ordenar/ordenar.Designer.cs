namespace Pizzaria_eddy.Ordenar
{
    partial class ordenar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordenar));
            this.L_tamano = new System.Windows.Forms.Label();
            this.Box_tamano = new System.Windows.Forms.ComboBox();
            this.IngredientesCBX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.L_ingrediente_1 = new System.Windows.Forms.Label();
            this.L_Ingrediente_2 = new System.Windows.Forms.Label();
            this.L_Ingrediente_3 = new System.Windows.Forms.Label();
            this.Ingrediente1CBX = new System.Windows.Forms.ComboBox();
            this.Ingrediente2CBX = new System.Windows.Forms.ComboBox();
            this.Ingrediente3CBX = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaborCBX = new System.Windows.Forms.ComboBox();
            this.TamanoCBX = new System.Windows.Forms.ComboBox();
            this.CantidadCBX = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Lb_Total = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.Si_radiobutton = new System.Windows.Forms.RadioButton();
            this.No_radiobutton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoCBX = new System.Windows.Forms.ComboBox();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ingrediente4CBX = new System.Windows.Forms.ComboBox();
            this.buttonPersonalizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRefrescos = new System.Windows.Forms.TextBox();
            this.txtxCostoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // L_tamano
            // 
            this.L_tamano.AutoSize = true;
            this.L_tamano.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_tamano.Location = new System.Drawing.Point(231, 125);
            this.L_tamano.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_tamano.Name = "L_tamano";
            this.L_tamano.Size = new System.Drawing.Size(154, 19);
            this.L_tamano.TabIndex = 0;
            this.L_tamano.Text = "Seleccione el Tamaño";
            // 
            // Box_tamano
            // 
            this.Box_tamano.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_tamano.FormattingEnabled = true;
            this.Box_tamano.Items.AddRange(new object[] {
            "Chica",
            "Mediana ",
            "Grande Familiar"});
            this.Box_tamano.Location = new System.Drawing.Point(235, 166);
            this.Box_tamano.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Box_tamano.Name = "Box_tamano";
            this.Box_tamano.Size = new System.Drawing.Size(150, 23);
            this.Box_tamano.TabIndex = 1;
            this.Box_tamano.Text = " Seleccione Una Opcion";
            this.Box_tamano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Box_tamano_KeyPress);
            // 
            // IngredientesCBX
            // 
            this.IngredientesCBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.IngredientesCBX.FormattingEnabled = true;
            this.IngredientesCBX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.IngredientesCBX.Location = new System.Drawing.Point(54, 235);
            this.IngredientesCBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IngredientesCBX.Name = "IngredientesCBX";
            this.IngredientesCBX.Size = new System.Drawing.Size(91, 23);
            this.IngredientesCBX.TabIndex = 2;
            this.IngredientesCBX.SelectedIndexChanged += new System.EventHandler(this.IngredientesCBX_SelectedIndexChanged);
            this.IngredientesCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IngredientesCBX_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingredientes";
            // 
            // L_ingrediente_1
            // 
            this.L_ingrediente_1.AutoSize = true;
            this.L_ingrediente_1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_ingrediente_1.Location = new System.Drawing.Point(53, 273);
            this.L_ingrediente_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_ingrediente_1.Name = "L_ingrediente_1";
            this.L_ingrediente_1.Size = new System.Drawing.Size(93, 18);
            this.L_ingrediente_1.TabIndex = 4;
            this.L_ingrediente_1.Text = "Ingrediente 1";
            // 
            // L_Ingrediente_2
            // 
            this.L_Ingrediente_2.AutoSize = true;
            this.L_Ingrediente_2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ingrediente_2.Location = new System.Drawing.Point(257, 273);
            this.L_Ingrediente_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Ingrediente_2.Name = "L_Ingrediente_2";
            this.L_Ingrediente_2.Size = new System.Drawing.Size(98, 19);
            this.L_Ingrediente_2.TabIndex = 5;
            this.L_Ingrediente_2.Text = "Ingrediente 2";
            // 
            // L_Ingrediente_3
            // 
            this.L_Ingrediente_3.AutoSize = true;
            this.L_Ingrediente_3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Ingrediente_3.Location = new System.Drawing.Point(457, 272);
            this.L_Ingrediente_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Ingrediente_3.Name = "L_Ingrediente_3";
            this.L_Ingrediente_3.Size = new System.Drawing.Size(98, 19);
            this.L_Ingrediente_3.TabIndex = 6;
            this.L_Ingrediente_3.Text = "Ingrediente 3";
            // 
            // Ingrediente1CBX
            // 
            this.Ingrediente1CBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Ingrediente1CBX.FormattingEnabled = true;
            this.Ingrediente1CBX.Items.AddRange(new object[] {
            "Jamon",
            "Queso",
            "Peperoni",
            "Chorizo",
            "Salchicha",
            "Piña",
            "Mozzarella",
            "Salsa de Tomate",
            "Salami"});
            this.Ingrediente1CBX.Location = new System.Drawing.Point(56, 309);
            this.Ingrediente1CBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ingrediente1CBX.Name = "Ingrediente1CBX";
            this.Ingrediente1CBX.Size = new System.Drawing.Size(146, 23);
            this.Ingrediente1CBX.TabIndex = 3;
            this.Ingrediente1CBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ingrediente1CBX_KeyPress);
            // 
            // Ingrediente2CBX
            // 
            this.Ingrediente2CBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Ingrediente2CBX.FormattingEnabled = true;
            this.Ingrediente2CBX.Items.AddRange(new object[] {
            "Jamon",
            "Queso",
            "Peperoni",
            "Chorizo",
            "Salchicha",
            "Piña",
            "Mozzarella",
            "Salsa de Tomate",
            "Salami"});
            this.Ingrediente2CBX.Location = new System.Drawing.Point(261, 309);
            this.Ingrediente2CBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ingrediente2CBX.Name = "Ingrediente2CBX";
            this.Ingrediente2CBX.Size = new System.Drawing.Size(144, 23);
            this.Ingrediente2CBX.TabIndex = 4;
            this.Ingrediente2CBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ingrediente2CBX_KeyPress);
            // 
            // Ingrediente3CBX
            // 
            this.Ingrediente3CBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Ingrediente3CBX.FormattingEnabled = true;
            this.Ingrediente3CBX.Items.AddRange(new object[] {
            "Jamon",
            "Queso",
            "Peperoni",
            "Chorizo",
            "Salchicha",
            "Piña",
            "Mozzarella",
            "Salsa de Tomate",
            "Salami"});
            this.Ingrediente3CBX.Location = new System.Drawing.Point(461, 308);
            this.Ingrediente3CBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ingrediente3CBX.Name = "Ingrediente3CBX";
            this.Ingrediente3CBX.Size = new System.Drawing.Size(160, 23);
            this.Ingrediente3CBX.TabIndex = 5;
            this.Ingrediente3CBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ingrediente3CBX_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Refresco";
            // 
            // SaborCBX
            // 
            this.SaborCBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.SaborCBX.FormattingEnabled = true;
            this.SaborCBX.Items.AddRange(new object[] {
            "Coca-Cola",
            "Manzanita",
            "7Seven",
            "Fanta"});
            this.SaborCBX.Location = new System.Drawing.Point(52, 420);
            this.SaborCBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SaborCBX.Name = "SaborCBX";
            this.SaborCBX.Size = new System.Drawing.Size(70, 23);
            this.SaborCBX.TabIndex = 8;
            this.SaborCBX.Text = "Sabor";
            this.SaborCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaborCBX_KeyPress);
            // 
            // TamanoCBX
            // 
            this.TamanoCBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.TamanoCBX.FormattingEnabled = true;
            this.TamanoCBX.Items.AddRange(new object[] {
            "Chica 355ml",
            "Mediana 500ml",
            "Grande 2.5lts"});
            this.TamanoCBX.Location = new System.Drawing.Point(180, 420);
            this.TamanoCBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TamanoCBX.Name = "TamanoCBX";
            this.TamanoCBX.Size = new System.Drawing.Size(114, 23);
            this.TamanoCBX.TabIndex = 9;
            this.TamanoCBX.Text = "Tamaño";
            this.TamanoCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TamanoCBX_KeyPress);
            // 
            // CantidadCBX
            // 
            this.CantidadCBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.CantidadCBX.FormattingEnabled = true;
            this.CantidadCBX.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CantidadCBX.Location = new System.Drawing.Point(351, 420);
            this.CantidadCBX.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CantidadCBX.Name = "CantidadCBX";
            this.CantidadCBX.Size = new System.Drawing.Size(117, 23);
            this.CantidadCBX.TabIndex = 10;
            this.CantidadCBX.Text = "0";
            this.CantidadCBX.SelectedIndexChanged += new System.EventHandler(this.CantidadCBX_SelectedIndexChanged);
            this.CantidadCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadCBX_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(461, 495);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(68, 26);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.Text = "0";
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // Lb_Total
            // 
            this.Lb_Total.AutoSize = true;
            this.Lb_Total.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Total.Location = new System.Drawing.Point(690, 469);
            this.Lb_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Total.Name = "Lb_Total";
            this.Lb_Total.Size = new System.Drawing.Size(44, 19);
            this.Lb_Total.TabIndex = 17;
            this.Lb_Total.Text = "Total";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(509, 565);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(94, 23);
            this.buttonConfirmar.TabIndex = 20;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "A Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(52, 495);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(303, 22);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(641, 565);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(762, 565);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 22;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // Si_radiobutton
            // 
            this.Si_radiobutton.AutoSize = true;
            this.Si_radiobutton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Si_radiobutton.Location = new System.Drawing.Point(141, 376);
            this.Si_radiobutton.Name = "Si_radiobutton";
            this.Si_radiobutton.Size = new System.Drawing.Size(41, 23);
            this.Si_radiobutton.TabIndex = 6;
            this.Si_radiobutton.Text = "Si";
            this.Si_radiobutton.UseVisualStyleBackColor = true;
            this.Si_radiobutton.CheckedChanged += new System.EventHandler(this.Si_radiobutton_CheckedChanged);
            // 
            // No_radiobutton
            // 
            this.No_radiobutton.AutoSize = true;
            this.No_radiobutton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.No_radiobutton.Location = new System.Drawing.Point(213, 376);
            this.No_radiobutton.Name = "No_radiobutton";
            this.No_radiobutton.Size = new System.Drawing.Size(47, 23);
            this.No_radiobutton.TabIndex = 7;
            this.No_radiobutton.Text = "No";
            this.No_radiobutton.UseVisualStyleBackColor = true;
            this.No_radiobutton.CheckedChanged += new System.EventHandler(this.No_radiobutton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tipos Existentes";
            // 
            // TipoCBX
            // 
            this.TipoCBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.TipoCBX.FormattingEnabled = true;
            this.TipoCBX.Items.AddRange(new object[] {
            "Hawaiana",
            "Pepperoni",
            "Funghi",
            "Vegetariana"});
            this.TipoCBX.Location = new System.Drawing.Point(52, 166);
            this.TipoCBX.Name = "TipoCBX";
            this.TipoCBX.Size = new System.Drawing.Size(130, 23);
            this.TipoCBX.TabIndex = 0;
            this.TipoCBX.Text = " Seleccione Una Opcion";
            this.TipoCBX.SelectedIndexChanged += new System.EventHandler(this.TipoCBX_SelectedIndexChanged);
            this.TipoCBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoCBX_KeyPress);
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.Image = global::Pizzaria_eddy.Properties.Resources.help_opt1;
            this.buttonAyuda.Location = new System.Drawing.Point(185, 166);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(28, 23);
            this.buttonAyuda.TabIndex = 90;
            this.buttonAyuda.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pizzaria_eddy.Properties.Resources.eddy;
            this.pictureBox2.Location = new System.Drawing.Point(-6, -11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizzaria_eddy.Properties.Resources.help_opt1;
            this.pictureBox1.Location = new System.Drawing.Point(921, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "Ingrediente 4";
            // 
            // Ingrediente4CBX
            // 
            this.Ingrediente4CBX.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Ingrediente4CBX.FormattingEnabled = true;
            this.Ingrediente4CBX.Items.AddRange(new object[] {
            "Jamon",
            "Queso",
            "Peperoni",
            "Chorizo",
            "Salchicha",
            "Piña",
            "Mozzarella",
            "Salsa de Tomate",
            "Salami"});
            this.Ingrediente4CBX.Location = new System.Drawing.Point(688, 308);
            this.Ingrediente4CBX.Name = "Ingrediente4CBX";
            this.Ingrediente4CBX.Size = new System.Drawing.Size(149, 23);
            this.Ingrediente4CBX.TabIndex = 92;
            this.Ingrediente4CBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ingrediente4CBX_KeyPress);
            // 
            // buttonPersonalizar
            // 
            this.buttonPersonalizar.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.buttonPersonalizar.Location = new System.Drawing.Point(461, 166);
            this.buttonPersonalizar.Name = "buttonPersonalizar";
            this.buttonPersonalizar.Size = new System.Drawing.Size(95, 23);
            this.buttonPersonalizar.TabIndex = 93;
            this.buttonPersonalizar.Text = "Perzonalizar";
            this.buttonPersonalizar.UseVisualStyleBackColor = true;
            this.buttonPersonalizar.Click += new System.EventHandler(this.buttonPersonalizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 499);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "$";
            // 
            // txtRefrescos
            // 
            this.txtRefrescos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtRefrescos.Location = new System.Drawing.Point(575, 495);
            this.txtRefrescos.Name = "txtRefrescos";
            this.txtRefrescos.Size = new System.Drawing.Size(75, 26);
            this.txtRefrescos.TabIndex = 95;
            this.txtRefrescos.Text = "0";
            this.txtRefrescos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefrescos_KeyPress);
            // 
            // txtxCostoTotal
            // 
            this.txtxCostoTotal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtxCostoTotal.Location = new System.Drawing.Point(694, 495);
            this.txtxCostoTotal.Name = "txtxCostoTotal";
            this.txtxCostoTotal.Size = new System.Drawing.Size(90, 26);
            this.txtxCostoTotal.TabIndex = 96;
            this.txtxCostoTotal.Text = "0";
            this.txtxCostoTotal.Enter += new System.EventHandler(this.txtxCostoTotal_Enter);
            this.txtxCostoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxCostoTotal_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 469);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "Pizza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 469);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 98;
            this.label8.Text = "Refresco";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 499);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 19);
            this.label9.TabIndex = 99;
            this.label9.Text = "+  $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(655, 499);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 19);
            this.label10.TabIndex = 100;
            this.label10.Text = "+  $";
            // 
            // ordenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 632);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtxCostoTotal);
            this.Controls.Add(this.txtRefrescos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPersonalizar);
            this.Controls.Add(this.Ingrediente4CBX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TipoCBX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.No_radiobutton);
            this.Controls.Add(this.Si_radiobutton);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.Lb_Total);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.CantidadCBX);
            this.Controls.Add(this.TamanoCBX);
            this.Controls.Add(this.SaborCBX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ingrediente3CBX);
            this.Controls.Add(this.Ingrediente2CBX);
            this.Controls.Add(this.Ingrediente1CBX);
            this.Controls.Add(this.L_Ingrediente_3);
            this.Controls.Add(this.L_Ingrediente_2);
            this.Controls.Add(this.L_ingrediente_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngredientesCBX);
            this.Controls.Add(this.Box_tamano);
            this.Controls.Add(this.L_tamano);
            this.Font = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ordenar";
            this.Text = "Pizza Eddy\'s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ordenar_FormClosing);
            this.Load += new System.EventHandler(this.ordenar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_tamano;
        private System.Windows.Forms.ComboBox Box_tamano;
        private System.Windows.Forms.ComboBox IngredientesCBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_ingrediente_1;
        private System.Windows.Forms.Label L_Ingrediente_2;
        private System.Windows.Forms.Label L_Ingrediente_3;
        private System.Windows.Forms.ComboBox Ingrediente1CBX;
        private System.Windows.Forms.ComboBox Ingrediente2CBX;
        private System.Windows.Forms.ComboBox Ingrediente3CBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SaborCBX;
        private System.Windows.Forms.ComboBox TamanoCBX;
        private System.Windows.Forms.ComboBox CantidadCBX;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label Lb_Total;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.RadioButton Si_radiobutton;
        private System.Windows.Forms.RadioButton No_radiobutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoCBX;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Ingrediente4CBX;
        private System.Windows.Forms.Button buttonPersonalizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRefrescos;
        private System.Windows.Forms.TextBox txtxCostoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}