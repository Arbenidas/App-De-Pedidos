namespace AppPedidos
{
    partial class ManejoClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inputApellidos = new System.Windows.Forms.TextBox();
            this.inputNombres = new System.Windows.Forms.TextBox();
            this.inputCorreo = new System.Windows.Forms.TextBox();
            this.inputContrasena = new System.Windows.Forms.TextBox();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAgregar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.botonLimpiar = new FontAwesome.Sharp.IconButton();
            this.botonActualizar = new FontAwesome.Sharp.IconButton();
            this.botonEliminar = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.botonBuscar = new FontAwesome.Sharp.IconButton();
            this.inputBusqueda = new System.Windows.Forms.TextBox();
            this.comboBuscarPor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(616, 131);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // inputApellidos
            // 
            this.inputApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputApellidos.Location = new System.Drawing.Point(368, 85);
            this.inputApellidos.Name = "inputApellidos";
            this.inputApellidos.Size = new System.Drawing.Size(107, 20);
            this.inputApellidos.TabIndex = 15;
            // 
            // inputNombres
            // 
            this.inputNombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNombres.Location = new System.Drawing.Point(127, 88);
            this.inputNombres.Name = "inputNombres";
            this.inputNombres.Size = new System.Drawing.Size(163, 20);
            this.inputNombres.TabIndex = 16;
            // 
            // inputCorreo
            // 
            this.inputCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCorreo.Location = new System.Drawing.Point(127, 60);
            this.inputCorreo.Name = "inputCorreo";
            this.inputCorreo.Size = new System.Drawing.Size(163, 20);
            this.inputCorreo.TabIndex = 17;
            // 
            // inputContrasena
            // 
            this.inputContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputContrasena.Location = new System.Drawing.Point(127, 123);
            this.inputContrasena.Name = "inputContrasena";
            this.inputContrasena.Size = new System.Drawing.Size(163, 20);
            this.inputContrasena.TabIndex = 18;
            // 
            // checkBoxAdministrador
            // 
            this.checkBoxAdministrador.AutoSize = true;
            this.checkBoxAdministrador.Location = new System.Drawing.Point(410, 125);
            this.checkBoxAdministrador.Name = "checkBoxAdministrador";
            this.checkBoxAdministrador.Size = new System.Drawing.Size(35, 17);
            this.checkBoxAdministrador.TabIndex = 24;
            this.checkBoxAdministrador.Text = "Si";
            this.checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(533, 125);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(35, 17);
            this.checkBoxActivo.TabIndex = 25;
            this.checkBoxActivo.Text = "Si";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Correo";
            // 
            // botonAgregar
            // 
            this.botonAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonAgregar.IconColor = System.Drawing.Color.Black;
            this.botonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonAgregar.Location = new System.Drawing.Point(604, 126);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 29;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Es Administrador?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Activo";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(127, 34);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(49, 20);
            this.textBoxID.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonLimpiar.IconColor = System.Drawing.Color.Black;
            this.botonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonLimpiar.Location = new System.Drawing.Point(493, 353);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 35;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonActualizar.IconColor = System.Drawing.Color.Black;
            this.botonActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonActualizar.Location = new System.Drawing.Point(493, 324);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(75, 23);
            this.botonActualizar.TabIndex = 36;
            this.botonActualizar.Text = "Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonEliminar.IconColor = System.Drawing.Color.Black;
            this.botonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonEliminar.Location = new System.Drawing.Point(604, 324);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 37;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Fecha";
            // 
            // botonBuscar
            // 
            this.botonBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonBuscar.IconColor = System.Drawing.Color.Black;
            this.botonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonBuscar.Location = new System.Drawing.Point(370, 326);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 40;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // inputBusqueda
            // 
            this.inputBusqueda.Location = new System.Drawing.Point(264, 329);
            this.inputBusqueda.Name = "inputBusqueda";
            this.inputBusqueda.Size = new System.Drawing.Size(100, 20);
            this.inputBusqueda.TabIndex = 41;
            // 
            // comboBuscarPor
            // 
            this.comboBuscarPor.FormattingEnabled = true;
            this.comboBuscarPor.Items.AddRange(new object[] {
            "Nombres",
            "Apellidos",
            "Correo",
            "Activo"});
            this.comboBuscarPor.Location = new System.Drawing.Point(127, 328);
            this.comboBuscarPor.Name = "comboBuscarPor";
            this.comboBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.comboBuscarPor.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Buscar por";
            // 
            // ManejoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBuscarPor);
            this.Controls.Add(this.inputBusqueda);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.checkBoxAdministrador);
            this.Controls.Add(this.inputContrasena);
            this.Controls.Add(this.inputCorreo);
            this.Controls.Add(this.inputNombres);
            this.Controls.Add(this.inputApellidos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManejoClientes";
            this.Text = "ManejoClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox inputApellidos;
        private System.Windows.Forms.TextBox inputNombres;
        private System.Windows.Forms.TextBox inputCorreo;
        private System.Windows.Forms.TextBox inputContrasena;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton botonAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton botonLimpiar;
        private FontAwesome.Sharp.IconButton botonActualizar;
        private FontAwesome.Sharp.IconButton botonEliminar;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton botonBuscar;
        private System.Windows.Forms.TextBox inputBusqueda;
        private System.Windows.Forms.ComboBox comboBuscarPor;
        private System.Windows.Forms.Label label9;
    }
}