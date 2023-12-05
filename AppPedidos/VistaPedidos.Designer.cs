namespace AppPedidos
{
    partial class VistaPedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.botonBuscar = new FontAwesome.Sharp.IconButton();
            this.inputBusqueda = new System.Windows.Forms.TextBox();
            this.comboBuscarPor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.butonCambiarEstado = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(633, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Pedidos";
            // 
            // botonBuscar
            // 
            this.botonBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonBuscar.IconColor = System.Drawing.Color.Black;
            this.botonBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonBuscar.Location = new System.Drawing.Point(497, 95);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // inputBusqueda
            // 
            this.inputBusqueda.Location = new System.Drawing.Point(366, 93);
            this.inputBusqueda.Name = "inputBusqueda";
            this.inputBusqueda.Size = new System.Drawing.Size(100, 20);
            this.inputBusqueda.TabIndex = 3;
            // 
            // comboBuscarPor
            // 
            this.comboBuscarPor.FormattingEnabled = true;
            this.comboBuscarPor.Items.AddRange(new object[] {
            "IdUsuario",
            "Contacto",
            "Telefono",
            "Direccion"});
            this.comboBuscarPor.Location = new System.Drawing.Point(224, 92);
            this.comboBuscarPor.Name = "comboBuscarPor";
            this.comboBuscarPor.Size = new System.Drawing.Size(121, 21);
            this.comboBuscarPor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar compra por";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(158, 316);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(56, 20);
            this.textBoxID.TabIndex = 6;
            // 
            // butonCambiarEstado
            // 
            this.butonCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.butonCambiarEstado.IconColor = System.Drawing.Color.Black;
            this.butonCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butonCambiarEstado.Location = new System.Drawing.Point(220, 316);
            this.butonCambiarEstado.Name = "butonCambiarEstado";
            this.butonCambiarEstado.Size = new System.Drawing.Size(172, 23);
            this.butonCambiarEstado.TabIndex = 7;
            this.butonCambiarEstado.Text = "Cambiar estado de compra";
            this.butonCambiarEstado.UseVisualStyleBackColor = true;
            this.butonCambiarEstado.Click += new System.EventHandler(this.butonCambiarEstado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID de compra";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(436, 319);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(136, 23);
            this.iconButton1.TabIndex = 9;
            this.iconButton1.Text = "Ver detalles";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // VistaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butonCambiarEstado);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBuscarPor);
            this.Controls.Add(this.inputBusqueda);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VistaPedidos";
            this.Text = "VistaPedidos";
            this.Load += new System.EventHandler(this.VistaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton botonBuscar;
        private System.Windows.Forms.TextBox inputBusqueda;
        private System.Windows.Forms.ComboBox comboBuscarPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private FontAwesome.Sharp.IconButton butonCambiarEstado;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}