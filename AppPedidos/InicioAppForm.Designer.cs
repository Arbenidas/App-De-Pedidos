
namespace AppPedidos
{
    partial class formularioHome
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
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.InicioButton = new FontAwesome.Sharp.IconMenuItem();
            this.seccionProductos = new FontAwesome.Sharp.IconMenuItem();
            this.misProductos = new FontAwesome.Sharp.IconMenuItem();
            this.menuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.menuMarcas = new FontAwesome.Sharp.IconMenuItem();
            this.reporteProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem9 = new FontAwesome.Sharp.IconMenuItem();
            this.usuarioToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.editarPerfilToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.cerrarSesionToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.miembrosToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.salirToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timerProduc = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.PanelDesktop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 450);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InicioButton,
            this.seccionProductos,
            this.iconMenuItem3,
            this.iconMenuItem9,
            this.usuarioToolStripMenuItem,
            this.miembrosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // InicioButton
            // 
            this.InicioButton.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.InicioButton.IconColor = System.Drawing.Color.Black;
            this.InicioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InicioButton.Name = "InicioButton";
            this.InicioButton.Size = new System.Drawing.Size(64, 20);
            this.InicioButton.Text = "Inicio";
            this.InicioButton.Click += new System.EventHandler(this.InicioButton_Click);
            // 
            // seccionProductos
            // 
            this.seccionProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misProductos,
            this.menuCategorias,
            this.menuMarcas,
            this.reporteProductosToolStripMenuItem});
            this.seccionProductos.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.seccionProductos.IconColor = System.Drawing.Color.Black;
            this.seccionProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.seccionProductos.Name = "seccionProductos";
            this.seccionProductos.Size = new System.Drawing.Size(111, 20);
            this.seccionProductos.Text = "Mis productos";
            this.seccionProductos.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // misProductos
            // 
            this.misProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.misProductos.IconColor = System.Drawing.Color.Black;
            this.misProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.misProductos.Name = "misProductos";
            this.misProductos.Size = new System.Drawing.Size(172, 22);
            this.misProductos.Text = "Productos";
            this.misProductos.Click += new System.EventHandler(this.misProductos_Click);
            // 
            // menuCategorias
            // 
            this.menuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuCategorias.IconColor = System.Drawing.Color.Black;
            this.menuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(172, 22);
            this.menuCategorias.Text = "Categorias";
            this.menuCategorias.Click += new System.EventHandler(this.menuCategorias_Click);
            // 
            // menuMarcas
            // 
            this.menuMarcas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuMarcas.IconColor = System.Drawing.Color.Black;
            this.menuMarcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMarcas.Name = "menuMarcas";
            this.menuMarcas.Size = new System.Drawing.Size(172, 22);
            this.menuMarcas.Text = "Marcas";
            this.menuMarcas.Click += new System.EventHandler(this.menuMarcas_Click);
            // 
            // reporteProductosToolStripMenuItem
            // 
            this.reporteProductosToolStripMenuItem.Name = "reporteProductosToolStripMenuItem";
            this.reporteProductosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.reporteProductosToolStripMenuItem.Text = "Reporte productos";
            this.reporteProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteProductosToolStripMenuItem_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(77, 20);
            this.iconMenuItem3.Text = "Clientes";
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // iconMenuItem9
            // 
            this.iconMenuItem9.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconMenuItem9.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem9.Name = "iconMenuItem9";
            this.iconMenuItem9.Size = new System.Drawing.Size(69, 20);
            this.iconMenuItem9.Text = "Ventas";
            this.iconMenuItem9.Click += new System.EventHandler(this.iconMenuItem9_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarPerfilToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.usuarioToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.User;
            this.usuarioToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.usuarioToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.usuarioToolStripMenuItem.Text = "usuario";
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.editarPerfilToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.editarPerfilToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.cerrarSesionToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.cerrarSesionToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // miembrosToolStripMenuItem
            // 
            this.miembrosToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.miembrosToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.miembrosToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.miembrosToolStripMenuItem.Name = "miembrosToolStripMenuItem";
            this.miembrosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.miembrosToolStripMenuItem.Text = "Miembros";
            this.miembrosToolStripMenuItem.Click += new System.EventHandler(this.miembrosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.salirToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.salirToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.PanelDesktop.Controls.Add(this.label8);
            this.PanelDesktop.Controls.Add(this.label9);
            this.PanelDesktop.Controls.Add(this.label10);
            this.PanelDesktop.Controls.Add(this.label7);
            this.PanelDesktop.Controls.Add(this.label6);
            this.PanelDesktop.Controls.Add(this.label5);
            this.PanelDesktop.Controls.Add(this.label4);
            this.PanelDesktop.Controls.Add(this.label3);
            this.PanelDesktop.Controls.Add(this.label2);
            this.PanelDesktop.Controls.Add(this.label1);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(0, 0);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(831, 450);
            this.PanelDesktop.TabIndex = 9;
            this.PanelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            this.PanelDesktop.Resize += new System.EventHandler(this.PanelDesktop_Resize);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(425, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            // 
            // timer4
            // 
            this.timer4.Interval = 10;

            // 
            // timerProduc
            // 
            this.timerProduc.Tick += new System.EventHandler(this.timerProduc_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem4.Text = "iconMenuItem4";
            this.iconMenuItem4.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aplicacion de escritorio para gestion de compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Administrador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "-Realizar compras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "-Edicion de perfil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "-Gestion de compras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "-Realizacion de reportes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "-Edicion de perfil de clientes y designacion de Nuevos administradores";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(354, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "-Editar base de datos";
            // 
            // formularioHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formularioHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.formularioHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerProduc;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem misProductos;
        private FontAwesome.Sharp.IconMenuItem menuCategorias;
        private FontAwesome.Sharp.IconMenuItem menuMarcas;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem9;
        private FontAwesome.Sharp.IconMenuItem InicioButton;
        private FontAwesome.Sharp.IconMenuItem seccionProductos;
        private FontAwesome.Sharp.IconMenuItem usuarioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem editarPerfilToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem cerrarSesionToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem salirToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem miembrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProductosToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}