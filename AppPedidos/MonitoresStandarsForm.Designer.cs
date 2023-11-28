
namespace AppPedidos
{
    partial class MonitoresStandarsForm
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
            this.PanelDeProdcutos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.mandarCarrito = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDeProdcutos
            // 
            this.PanelDeProdcutos.AutoScroll = true;
            this.PanelDeProdcutos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelDeProdcutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeProdcutos.Location = new System.Drawing.Point(0, 0);
            this.PanelDeProdcutos.Name = "PanelDeProdcutos";
            this.PanelDeProdcutos.Size = new System.Drawing.Size(800, 450);
            this.PanelDeProdcutos.TabIndex = 1;
            this.PanelDeProdcutos.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDeProdcutos_Paint);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.mandarCarrito);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 100);
            this.panelTop.TabIndex = 2;
            // 
            // mandarCarrito
            // 
            this.mandarCarrito.IconChar = FontAwesome.Sharp.IconChar.None;
            this.mandarCarrito.IconColor = System.Drawing.Color.Black;
            this.mandarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mandarCarrito.Location = new System.Drawing.Point(0, 40);
            this.mandarCarrito.Name = "mandarCarrito";
            this.mandarCarrito.Size = new System.Drawing.Size(136, 23);
            this.mandarCarrito.TabIndex = 0;
            this.mandarCarrito.Text = "Mandar al carrito";
            this.mandarCarrito.UseVisualStyleBackColor = true;
            // 
            // MonitoresStandarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.PanelDeProdcutos);
            this.Name = "MonitoresStandarsForm";
            this.Text = "MonitoresStandars";
            this.Load += new System.EventHandler(this.MonitoresStandars_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelDeProdcutos;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton mandarCarrito;
    }
}