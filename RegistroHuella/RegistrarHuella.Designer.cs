﻿
namespace RegistroHuella
{
    partial class RegistrarHuella
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
            this.Curp = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCompleto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaIngreso = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreMunicipio = new System.Windows.Forms.Label();
            this.capturarHuell = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.capturarHuell)).BeginInit();
            this.SuspendLayout();
            // 
            // Curp
            // 
            this.Curp.Location = new System.Drawing.Point(32, 103);
            this.Curp.Name = "Curp";
            this.Curp.Size = new System.Drawing.Size(245, 20);
            this.Curp.TabIndex = 0;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(296, 103);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el CURP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Completo";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Location = new System.Drawing.Point(30, 195);
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Size = new System.Drawing.Size(339, 20);
            this.NombreCompleto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cargo";
            // 
            // Cargo
            // 
            this.Cargo.Location = new System.Drawing.Point(401, 195);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(127, 20);
            this.Cargo.TabIndex = 7;
            this.Cargo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Ingreso";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Location = new System.Drawing.Point(574, 195);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(127, 20);
            this.FechaIngreso.TabIndex = 9;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(278, 376);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(158, 46);
            this.Registrar.TabIndex = 10;
            this.Registrar.Text = "Registrar Huella";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inmueble :";
            // 
            // NombreMunicipio
            // 
            this.NombreMunicipio.AutoSize = true;
            this.NombreMunicipio.Location = new System.Drawing.Point(408, 20);
            this.NombreMunicipio.Name = "NombreMunicipio";
            this.NombreMunicipio.Size = new System.Drawing.Size(50, 13);
            this.NombreMunicipio.TabIndex = 13;
            this.NombreMunicipio.Text = "Inmueble";
            // 
            // capturarHuell
            // 
            this.capturarHuell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capturarHuell.Enabled = false;
            this.capturarHuell.Image = global::RegistroHuella.Properties.Resources.baseline_fingerprint_black_48dp;
            this.capturarHuell.Location = new System.Drawing.Point(308, 245);
            this.capturarHuell.Name = "capturarHuell";
            this.capturarHuell.Size = new System.Drawing.Size(94, 105);
            this.capturarHuell.TabIndex = 11;
            this.capturarHuell.TabStop = false;
            this.capturarHuell.Click += new System.EventHandler(this.capturarHuell_Click);
            // 
            // RegistrarHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.NombreMunicipio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.capturarHuell);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.FechaIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreCompleto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Curp);
            this.Name = "RegistrarHuella";
            this.Text = "CapturarHuella";
            ((System.ComponentModel.ISupportInitialize)(this.capturarHuell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Curp;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreCompleto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FechaIngreso;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.PictureBox capturarHuell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NombreMunicipio;
    }
}