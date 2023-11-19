
namespace AppPedidos
{
    partial class LaptopsEconomicas
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
            this.SuspendLayout();
            // 
            // PanelDeProdcutos
            // 
            this.PanelDeProdcutos.AutoScroll = true;
            this.PanelDeProdcutos.BackColor = System.Drawing.SystemColors.Highlight;
            this.PanelDeProdcutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDeProdcutos.Location = new System.Drawing.Point(0, 0);
            this.PanelDeProdcutos.Name = "PanelDeProdcutos";
            this.PanelDeProdcutos.Size = new System.Drawing.Size(800, 450);
            this.PanelDeProdcutos.TabIndex = 4;
            // 
            // LaptopsEconomicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelDeProdcutos);
            this.Name = "LaptopsEconomicas";
            this.Text = "LaptopsEconomicas";
            this.Load += new System.EventHandler(this.LaptopsEconomicas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelDeProdcutos;
    }
}