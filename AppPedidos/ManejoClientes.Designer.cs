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
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonAgregar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.botonLimpiar = new FontAwesome.Sharp.IconButton();
            this.botonActualizar = new FontAwesome.Sharp.IconButton();
            this.botonEliminar = new FontAwesome.Sharp.IconButton();
            this.botonBuscar = new FontAwesome.Sharp.IconButton();
            this.inputBusqueda = new System.Windows.Forms.TextBox();
            this.comboBuscarPor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputContrasena = new System.Windows.Forms.TextBox();
            this.inputCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.inputNombres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(415, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // inputApellidos
            // 
            this.inputApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputApellidos.Location = new System.Drawing.Point(88, 65);
            this.inputApellidos.Name = "inputApellidos";
            this.inputApellidos.Size = new System.Drawing.Size(107, 20);
            this.inputApellidos.TabIndex = 15;
            this.inputApellidos.TextChanged += new System.EventHandler(this.inputApellidos_TextChanged);
            // 
            // checkBoxAdministrador
            // 
            this.checkBoxAdministrador.AutoSize = true;
            this.checkBoxAdministrador.Location = new System.Drawing.Point(97, 30);
            this.checkBoxAdministrador.Name = "checkBoxAdministrador";
            this.checkBoxAdministrador.Size = new System.Drawing.Size(35, 17);
            this.checkBoxAdministrador.TabIndex = 24;
            this.checkBoxAdministrador.Text = "Si";
            this.checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(97, 56);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(35, 17);
            this.checkBoxActivo.TabIndex = 25;
            this.checkBoxActivo.Text = "Si";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            this.checkBoxActivo.CheckedChanged += new System.EventHandler(this.checkBoxActivo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonAgregar
            // 
            this.botonAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonAgregar.IconColor = System.Drawing.Color.Black;
            this.botonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonAgregar.Location = new System.Drawing.Point(13, 19);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 29;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Es Administrador?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Activo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonLimpiar.IconColor = System.Drawing.Color.Black;
            this.botonLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonLimpiar.Location = new System.Drawing.Point(694, 150);
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
            this.botonActualizar.Location = new System.Drawing.Point(479, 150);
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
            this.botonEliminar.Location = new System.Drawing.Point(13, 79);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 37;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonBuscar.IconColor = System.Drawing.Color.Black;
            this.botonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonBuscar.Location = new System.Drawing.Point(115, 49);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 40;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // inputBusqueda
            // 
            this.inputBusqueda.Location = new System.Drawing.Point(9, 52);
            this.inputBusqueda.Name = "inputBusqueda";
            this.inputBusqueda.Size = new System.Drawing.Size(100, 20);
            this.inputBusqueda.TabIndex = 41;
            this.inputBusqueda.TextChanged += new System.EventHandler(this.inputBusqueda_TextChanged);
            // 
            // comboBuscarPor
            // 
            this.comboBuscarPor.FormattingEnabled = true;
            this.comboBuscarPor.Items.AddRange(new object[] {
            "Nombres",
            "Apellidos",
            "Correo",
            "Activo"});
            this.comboBuscarPor.Location = new System.Drawing.Point(73, 19);
            this.comboBuscarPor.Name = "comboBuscarPor";
            this.comboBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.comboBuscarPor.TabIndex = 42;
            this.comboBuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBuscarPor_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Buscar por";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.botonActualizar);
            this.panel1.Controls.Add(this.botonLimpiar);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 44;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.botonAgregar);
            this.groupBox5.Controls.Add(this.botonEliminar);
            this.groupBox5.Location = new System.Drawing.Point(117, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(134, 123);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edicion";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBuscarPor);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.inputBusqueda);
            this.groupBox4.Controls.Add(this.botonBuscar);
            this.groupBox4.Location = new System.Drawing.Point(569, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxAdministrador);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.checkBoxActivo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(114, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 100);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputContrasena);
            this.groupBox2.Controls.Add(this.inputCorreo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(354, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 101);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credenciales";
            // 
            // inputContrasena
            // 
            this.inputContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputContrasena.Location = new System.Drawing.Point(78, 58);
            this.inputContrasena.Name = "inputContrasena";
            this.inputContrasena.Size = new System.Drawing.Size(106, 20);
            this.inputContrasena.TabIndex = 47;
            // 
            // inputCorreo
            // 
            this.inputCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCorreo.Location = new System.Drawing.Point(78, 24);
            this.inputCorreo.Name = "inputCorreo";
            this.inputCorreo.Size = new System.Drawing.Size(106, 20);
            this.inputCorreo.TabIndex = 44;
            this.inputCorreo.TextChanged += new System.EventHandler(this.inputCorreo_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Correo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.inputNombres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputApellidos);
            this.groupBox1.Location = new System.Drawing.Point(114, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 150);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(88, 36);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(49, 20);
            this.textBoxID.TabIndex = 46;
            // 
            // inputNombres
            // 
            this.inputNombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNombres.Location = new System.Drawing.Point(88, 90);
            this.inputNombres.Name = "inputNombres";
            this.inputNombres.Size = new System.Drawing.Size(106, 20);
            this.inputNombres.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombres";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 450);
            this.panel2.TabIndex = 44;
            // 
            // ManejoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ManejoClientes";
            this.Text = "ManejoClientes";
            this.Load += new System.EventHandler(this.ManejoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox inputApellidos;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton botonAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton botonLimpiar;
        private FontAwesome.Sharp.IconButton botonActualizar;
        private FontAwesome.Sharp.IconButton botonEliminar;
        private FontAwesome.Sharp.IconButton botonBuscar;
        private System.Windows.Forms.TextBox inputBusqueda;
        private System.Windows.Forms.ComboBox comboBuscarPor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox inputContrasena;
        private System.Windows.Forms.TextBox inputCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox inputNombres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}