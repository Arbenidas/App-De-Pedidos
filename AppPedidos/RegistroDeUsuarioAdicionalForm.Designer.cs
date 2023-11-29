
namespace AppPedidos
{
    partial class RegistroDeUsuarioAdicionalForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.inputNombres = new System.Windows.Forms.TextBox();
            this.inputCorreo = new System.Windows.Forms.TextBox();
            this.inputContrasena = new System.Windows.Forms.TextBox();
            this.inputApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(155)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 9;
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(178)))));
            this.buttonRegistro.ForeColor = System.Drawing.Color.White;
            this.buttonRegistro.Location = new System.Drawing.Point(384, 247);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(251, 43);
            this.buttonRegistro.TabIndex = 10;
            this.buttonRegistro.Text = "Completar Registro";
            this.buttonRegistro.UseVisualStyleBackColor = false;
            this.buttonRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNombres
            // 
            this.inputNombres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNombres.Location = new System.Drawing.Point(281, 74);
            this.inputNombres.Name = "inputNombres";
            this.inputNombres.Size = new System.Drawing.Size(163, 20);
            this.inputNombres.TabIndex = 11;
            // 
            // inputCorreo
            // 
            this.inputCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCorreo.Location = new System.Drawing.Point(281, 148);
            this.inputCorreo.Name = "inputCorreo";
            this.inputCorreo.Size = new System.Drawing.Size(163, 20);
            this.inputCorreo.TabIndex = 12;
            // 
            // inputContrasena
            // 
            this.inputContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputContrasena.Location = new System.Drawing.Point(553, 148);
            this.inputContrasena.Name = "inputContrasena";
            this.inputContrasena.Size = new System.Drawing.Size(163, 20);
            this.inputContrasena.TabIndex = 13;
            // 
            // inputApellidos
            // 
            this.inputApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputApellidos.Location = new System.Drawing.Point(553, 74);
            this.inputApellidos.Name = "inputApellidos";
            this.inputApellidos.Size = new System.Drawing.Size(163, 20);
            this.inputApellidos.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(278, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(278, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Correo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(550, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(583, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Apellidos";
            // 
            // RegistroDeUsuarioAdicionalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputApellidos);
            this.Controls.Add(this.inputContrasena);
            this.Controls.Add(this.inputCorreo);
            this.Controls.Add(this.inputNombres);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.panel1);
            this.Name = "RegistroDeUsuarioAdicionalForm";
            this.Text = "Registro2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.TextBox inputNombres;
        private System.Windows.Forms.TextBox inputCorreo;
        private System.Windows.Forms.TextBox inputContrasena;
        private System.Windows.Forms.TextBox inputApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}