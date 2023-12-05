namespace AppPedidos
{
    partial class VistaCarrito
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
            this.label1 = new System.Windows.Forms.Label();
            this.PanelDeProdcutos = new System.Windows.Forms.FlowLayoutPanel();
            this.botonDeComprar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tus Productos";
            // 
            // PanelDeProdcutos
            // 
            this.PanelDeProdcutos.AutoScroll = true;
            this.PanelDeProdcutos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelDeProdcutos.Location = new System.Drawing.Point(12, 44);
            this.PanelDeProdcutos.Name = "PanelDeProdcutos";
            this.PanelDeProdcutos.Size = new System.Drawing.Size(601, 366);
            this.PanelDeProdcutos.TabIndex = 2;
            // 
            // botonDeComprar
            // 
            this.botonDeComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(140)))), ((int)(((byte)(212)))));
            this.botonDeComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDeComprar.ForeColor = System.Drawing.Color.White;
            this.botonDeComprar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.botonDeComprar.IconColor = System.Drawing.Color.Black;
            this.botonDeComprar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonDeComprar.Location = new System.Drawing.Point(15, 339);
            this.botonDeComprar.Name = "botonDeComprar";
            this.botonDeComprar.Size = new System.Drawing.Size(154, 71);
            this.botonDeComprar.TabIndex = 3;
            this.botonDeComprar.Text = "Realizar Compras";
            this.botonDeComprar.UseVisualStyleBackColor = false;
            this.botonDeComprar.Click += new System.EventHandler(this.botonDeComprar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(148)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.botonDeComprar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 450);
            this.panel1.TabIndex = 4;
            // 
            // VistaCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelDeProdcutos);
            this.Controls.Add(this.label1);
            this.Name = "VistaCarrito";
            this.Text = "VistaCarrito";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PanelDeProdcutos;
        private FontAwesome.Sharp.IconButton botonDeComprar;
        private System.Windows.Forms.Panel panel1;
    }
}