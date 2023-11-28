
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
            this.seccionProductos = new FontAwesome.Sharp.IconMenuItem();
            this.misProductos = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem12 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem13 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem14 = new FontAwesome.Sharp.IconMenuItem();
            this.menuCategorias = new FontAwesome.Sharp.IconMenuItem();
            this.menuMarcas = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem9 = new FontAwesome.Sharp.IconMenuItem();
            this.InicioButton = new FontAwesome.Sharp.IconMenuItem();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timerProduc = new System.Windows.Forms.Timer(this.components);
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.usuarioToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.editarPerfilToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.cerrarSesionToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.salirToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.sideBarTimer_Tick2);
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
            this.seccionProductos,
            this.iconMenuItem3,
            this.iconMenuItem9,
            this.InicioButton,
            this.usuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seccionProductos
            // 
            this.seccionProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misProductos,
            this.menuCategorias,
            this.menuMarcas});
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
            this.misProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem8,
            this.iconMenuItem12,
            this.iconMenuItem13,
            this.iconMenuItem14});
            this.misProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.misProductos.IconColor = System.Drawing.Color.Black;
            this.misProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.misProductos.Name = "misProductos";
            this.misProductos.Size = new System.Drawing.Size(180, 22);
            this.misProductos.Text = "Productos";
            this.misProductos.Click += new System.EventHandler(this.misProductos_Click);
            // 
            // iconMenuItem8
            // 
            this.iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem8.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem8.Name = "iconMenuItem8";
            this.iconMenuItem8.Size = new System.Drawing.Size(136, 22);
            this.iconMenuItem8.Text = "Monitores";
            // 
            // iconMenuItem12
            // 
            this.iconMenuItem12.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem12.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem12.Name = "iconMenuItem12";
            this.iconMenuItem12.Size = new System.Drawing.Size(136, 22);
            this.iconMenuItem12.Text = "Laptop";
            // 
            // iconMenuItem13
            // 
            this.iconMenuItem13.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem13.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem13.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem13.Name = "iconMenuItem13";
            this.iconMenuItem13.Size = new System.Drawing.Size(136, 22);
            this.iconMenuItem13.Text = "Audiculares";
            // 
            // iconMenuItem14
            // 
            this.iconMenuItem14.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem14.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem14.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem14.Name = "iconMenuItem14";
            this.iconMenuItem14.Size = new System.Drawing.Size(136, 22);
            this.iconMenuItem14.Text = "Ratones";
            // 
            // menuCategorias
            // 
            this.menuCategorias.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuCategorias.IconColor = System.Drawing.Color.Black;
            this.menuCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(180, 22);
            this.menuCategorias.Text = "Categorias";
            // 
            // menuMarcas
            // 
            this.menuMarcas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuMarcas.IconColor = System.Drawing.Color.Black;
            this.menuMarcas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMarcas.Name = "menuMarcas";
            this.menuMarcas.Size = new System.Drawing.Size(180, 22);
            this.menuMarcas.Text = "Marcas";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(77, 20);
            this.iconMenuItem3.Text = "Clientes";
            // 
            // iconMenuItem9
            // 
            this.iconMenuItem9.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem9.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem9.Name = "iconMenuItem9";
            this.iconMenuItem9.Size = new System.Drawing.Size(69, 20);
            this.iconMenuItem9.Text = "Ventas";
            // 
            // InicioButton
            // 
            this.InicioButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.InicioButton.IconColor = System.Drawing.Color.Black;
            this.InicioButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InicioButton.Name = "InicioButton";
            this.InicioButton.Size = new System.Drawing.Size(64, 20);
            this.InicioButton.Text = "Inicio";
            // 
            // PanelDesktop
            // 
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
            this.label1.Location = new System.Drawing.Point(203, 40);
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
            this.timer2.Tick += new System.EventHandler(this.sideBarTimer_Tick3);
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.sideBarTimer_Tick4);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.sideBarTimer_Tick5);
            // 
            // timerProduc
            // 
            this.timerProduc.Tick += new System.EventHandler(this.timerProduc_Tick);
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
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
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
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.cerrarSesionToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.cerrarSesionToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
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
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
        private FontAwesome.Sharp.IconMenuItem menuCategorias;
        private FontAwesome.Sharp.IconMenuItem menuMarcas;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem9;
        private FontAwesome.Sharp.IconMenuItem InicioButton;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem12;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem13;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem14;
        private FontAwesome.Sharp.IconMenuItem seccionProductos;
        private FontAwesome.Sharp.IconMenuItem usuarioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem editarPerfilToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem cerrarSesionToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem salirToolStripMenuItem;
    }
}