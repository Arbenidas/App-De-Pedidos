
namespace AppPedidos
{
    partial class MisProductosVentas
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
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDesktop.Location = new System.Drawing.Point(0, 94);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(800, 356);
            this.PanelDesktop.TabIndex = 10;
            this.PanelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDesktop_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 11;
            // 
            // MisProductosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelDesktop);
            this.Name = "MisProductosVentas";
            this.Text = "MisProductosVentas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Panel panel1;
    }
}