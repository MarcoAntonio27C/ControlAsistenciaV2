
namespace GenerarAsistencia
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComboBoxInmueble = new System.Windows.Forms.ComboBox();
            this.ComboBoxMunicipio = new System.Windows.Forms.ComboBox();
            this.Municipio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(284, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione el Inmueble";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(335, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asistencia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GenerarAsistencia.Properties.Resources.Inmueble;
            this.pictureBox1.Location = new System.Drawing.Point(272, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ComboBoxInmueble
            // 
            this.ComboBoxInmueble.FormattingEnabled = true;
            this.ComboBoxInmueble.Location = new System.Drawing.Point(272, 507);
            this.ComboBoxInmueble.Name = "ComboBoxInmueble";
            this.ComboBoxInmueble.Size = new System.Drawing.Size(308, 21);
            this.ComboBoxInmueble.TabIndex = 10;
            // 
            // ComboBoxMunicipio
            // 
            this.ComboBoxMunicipio.FormattingEnabled = true;
            this.ComboBoxMunicipio.Location = new System.Drawing.Point(272, 461);
            this.ComboBoxMunicipio.Name = "ComboBoxMunicipio";
            this.ComboBoxMunicipio.Size = new System.Drawing.Size(306, 21);
            this.ComboBoxMunicipio.TabIndex = 15;
            this.ComboBoxMunicipio.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMunicipio_SelectedIndexChanged);
            // 
            // Municipio
            // 
            this.Municipio.AutoSize = true;
            this.Municipio.Location = new System.Drawing.Point(270, 445);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(52, 13);
            this.Municipio.TabIndex = 14;
            this.Municipio.Text = "Municipio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inmueble";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 613);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboBoxMunicipio);
            this.Controls.Add(this.Municipio);
            this.Controls.Add(this.ComboBoxInmueble);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fiscalia General del Estado de Puebla";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxInmueble;
        private System.Windows.Forms.ComboBox ComboBoxMunicipio;
        private System.Windows.Forms.Label Municipio;
        private System.Windows.Forms.Label label3;
    }
}

