﻿namespace AppPedidos
{
    partial class MarcaCRUD
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
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(372, 88);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 52;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(538, 336);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 51;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(457, 336);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 50;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "ID";
            // 
            // inputID
            // 
            this.inputID.Enabled = false;
            this.inputID.Location = new System.Drawing.Point(155, 58);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(100, 20);
            this.inputID.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 196);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(335, 93);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxEstado.TabIndex = 46;
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Activo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nombre:";
            // 
            // inputNombre
            // 
            this.inputNombre.Location = new System.Drawing.Point(155, 84);
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.Size = new System.Drawing.Size(100, 20);
            this.inputNombre.TabIndex = 43;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(466, 88);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 42;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // MarcaCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNombre);
            this.Controls.Add(this.buttonAgregar);
            this.Name = "MarcaCRUD";
            this.Text = "MarcaCRUD";
            this.Load += new System.EventHandler(this.MarcaCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNombre;
        private System.Windows.Forms.Button buttonAgregar;
    }
}