namespace AppPedidos
{
    partial class VistaClientes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuInicio = new FontAwesome.Sharp.IconMenuItem();
            this.comprasToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.misComprasToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.nuevoToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.usuarioToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.editarPerfilToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.cerrarSesionToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.carritoToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.salirToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInicio,
            this.comprasToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.carritoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuInicio
            // 
            this.menuInicio.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.menuInicio.IconColor = System.Drawing.Color.Black;
            this.menuInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuInicio.Name = "menuInicio";
            this.menuInicio.Size = new System.Drawing.Size(64, 20);
            this.menuInicio.Text = "Inicio";
            this.menuInicio.Click += new System.EventHandler(this.menuInicio_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misComprasToolStripMenuItem,
            this.nuevoToolStripMenuItem});
            this.comprasToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.comprasToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.comprasToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // misComprasToolStripMenuItem
            // 
            this.misComprasToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.misComprasToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.misComprasToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.misComprasToolStripMenuItem.Name = "misComprasToolStripMenuItem";
            this.misComprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.misComprasToolStripMenuItem.Text = "Mis compras";
            this.misComprasToolStripMenuItem.Click += new System.EventHandler(this.misComprasToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.nuevoToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.nuevoToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Categorias";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
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
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.editarPerfilToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.editarPerfilToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.cerrarSesionToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.cerrarSesionToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.carritoToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.carritoToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.carritoToolStripMenuItem.Text = "Carrito";
            this.carritoToolStripMenuItem.Click += new System.EventHandler(this.carritoToolStripMenuItem_Click);
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
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(0, 24);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(800, 426);
            this.PanelDesktop.TabIndex = 1;
            this.PanelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktop_Paint);
            // 
            // VistaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VistaClientes";
            this.Text = "VistaClientes";
            this.Load += new System.EventHandler(this.VistaClientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem menuInicio;
        private FontAwesome.Sharp.IconMenuItem comprasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem misComprasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.Panel PanelDesktop;
        private FontAwesome.Sharp.IconMenuItem usuarioToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem editarPerfilToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem cerrarSesionToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem salirToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem carritoToolStripMenuItem;
    }
}