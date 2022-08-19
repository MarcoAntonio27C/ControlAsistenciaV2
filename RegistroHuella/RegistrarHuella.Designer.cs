
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
            this.capturarHuell = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_inmueble = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capturarHuell)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Curp
            // 
            this.Curp.Location = new System.Drawing.Point(35, 186);
            this.Curp.Name = "Curp";
            this.Curp.Size = new System.Drawing.Size(245, 20);
            this.Curp.TabIndex = 0;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(299, 186);
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
            this.label2.Location = new System.Drawing.Point(35, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el CURP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Completo";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Location = new System.Drawing.Point(33, 240);
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Size = new System.Drawing.Size(341, 20);
            this.NombreCompleto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cargo";
            // 
            // Cargo
            // 
            this.Cargo.Location = new System.Drawing.Point(33, 292);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(341, 20);
            this.Cargo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Ingreso";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Location = new System.Drawing.Point(33, 341);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(341, 20);
            this.FechaIngreso.TabIndex = 9;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(124, 546);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(158, 46);
            this.Registrar.TabIndex = 10;
            this.Registrar.Text = "Registrar Huella";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // capturarHuell
            // 
            this.capturarHuell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capturarHuell.Enabled = false;
            this.capturarHuell.Image = global::RegistroHuella.Properties.Resources.baseline_fingerprint_black_48dp;
            this.capturarHuell.Location = new System.Drawing.Point(154, 415);
            this.capturarHuell.Name = "capturarHuell";
            this.capturarHuell.Size = new System.Drawing.Size(94, 105);
            this.capturarHuell.TabIndex = 11;
            this.capturarHuell.TabStop = false;
            this.capturarHuell.Click += new System.EventHandler(this.capturarHuell_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-363, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 10);
            this.panel2.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RegistroHuella.Properties.Resources.LogoFiscalia;
            this.pictureBox2.Location = new System.Drawing.Point(134, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label_inmueble
            // 
            this.label_inmueble.AutoSize = true;
            this.label_inmueble.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_inmueble.Location = new System.Drawing.Point(13, 118);
            this.label_inmueble.Name = "label_inmueble";
            this.label_inmueble.Size = new System.Drawing.Size(35, 13);
            this.label_inmueble.TabIndex = 34;
            this.label_inmueble.Text = "label5";
            // 
            // RegistrarHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(419, 616);
            this.Controls.Add(this.label_inmueble);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapturarHuella";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarHuella_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.capturarHuell)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_inmueble;
    }
}