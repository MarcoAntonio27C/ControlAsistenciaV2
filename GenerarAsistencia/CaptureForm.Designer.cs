using System.Windows.Forms;

namespace GenerarAsistencia
{
    partial class CaptureForm
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
            this.components = new System.ComponentModel.Container();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusLine = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Entrada = new System.Windows.Forms.RadioButton();
            this.SalidaComida = new System.Windows.Forms.RadioButton();
            this.RegresoComida = new System.Windows.Forms.RadioButton();
            this.Salida = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Prompt
            // 
            this.Prompt.Location = new System.Drawing.Point(20, 736);
            this.Prompt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(1661, 22);
            this.Prompt.TabIndex = 2;
            this.Prompt.Visible = false;
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.Location = new System.Drawing.Point(3, 793);
            this.StatusText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(1679, 42);
            this.StatusText.TabIndex = 4;
            this.StatusText.TextChanged += new System.EventHandler(this.StatusText_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(-321, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2029, 12);
            this.panel2.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1411, -21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(556, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "dfgfdgdgfdgfdgfdddddddddddddddddddddddddddddddddddddddddddddddddddddddd";
            // 
            // StatusLine
            // 
            this.StatusLine.Location = new System.Drawing.Point(16, 151);
            this.StatusLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(256, 48);
            this.StatusLine.TabIndex = 5;
            this.StatusLine.Text = "[Status line]";
            this.StatusLine.Visible = false;
            // 
            // reloj
            // 
            this.reloj.AutoSize = true;
            this.reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloj.ForeColor = System.Drawing.Color.Gray;
            this.reloj.Location = new System.Drawing.Point(708, 193);
            this.reloj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reloj.Name = "reloj";
            this.reloj.Size = new System.Drawing.Size(194, 69);
            this.reloj.TabIndex = 33;
            this.reloj.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(507, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 69);
            this.label2.TabIndex = 34;
            this.label2.Text = "Hora: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(523, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(621, 69);
            this.label3.TabIndex = 35;
            this.label3.Text = "Registra tu asistencia";
            // 
            // Entrada
            // 
            this.Entrada.AutoSize = true;
            this.Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrada.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Entrada.Location = new System.Drawing.Point(259, 324);
            this.Entrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(180, 50);
            this.Entrada.TabIndex = 37;
            this.Entrada.TabStop = true;
            this.Entrada.Text = "Entrada";
            this.Entrada.UseVisualStyleBackColor = true;
            this.Entrada.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // SalidaComida
            // 
            this.SalidaComida.AutoSize = true;
            this.SalidaComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalidaComida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.SalidaComida.Location = new System.Drawing.Point(259, 425);
            this.SalidaComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SalidaComida.Name = "SalidaComida";
            this.SalidaComida.Size = new System.Drawing.Size(334, 50);
            this.SalidaComida.TabIndex = 38;
            this.SalidaComida.TabStop = true;
            this.SalidaComida.Text = "Salida a Comida";
            this.SalidaComida.UseVisualStyleBackColor = true;
            this.SalidaComida.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // RegresoComida
            // 
            this.RegresoComida.AutoSize = true;
            this.RegresoComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresoComida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.RegresoComida.Location = new System.Drawing.Point(259, 514);
            this.RegresoComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegresoComida.Name = "RegresoComida";
            this.RegresoComida.Size = new System.Drawing.Size(341, 50);
            this.RegresoComida.TabIndex = 39;
            this.RegresoComida.TabStop = true;
            this.RegresoComida.Text = "Regreso Comida";
            this.RegresoComida.UseVisualStyleBackColor = true;
            // 
            // Salida
            // 
            this.Salida.AutoSize = true;
            this.Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Salida.Location = new System.Drawing.Point(259, 608);
            this.Salida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(152, 50);
            this.Salida.TabIndex = 40;
            this.Salida.TabStop = true;
            this.Salida.Text = "Salida";
            this.Salida.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(827, 324);
            this.Picture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(523, 358);
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1641, 838);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.RegresoComida);
            this.Controls.Add(this.SalidaComida);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reloj);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StatusLine);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.Picture);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CaptureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed);
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.Label reloj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public RadioButton Entrada;
        public RadioButton SalidaComida;
        public RadioButton RegresoComida;
        public RadioButton Salida;
        private Label label1;
        private Label label6;
        public PictureBox Picture;
    }
}