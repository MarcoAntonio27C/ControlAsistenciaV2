
namespace GenerarAsistencia
{
    partial class Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.inmueble2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrada
            // 
            this.Entrada.CheckedChanged += new System.EventHandler(this.Entrada_CheckedChanged);
            // 
            // SalidaComida
            // 
            this.SalidaComida.CheckedChanged += new System.EventHandler(this.SalidaComida_CheckedChanged);
            // 
            // RegresoComida
            // 
            this.RegresoComida.CheckedChanged += new System.EventHandler(this.RegresoComida_CheckedChanged);
            // 
            // Salida
            // 
            this.Salida.CheckedChanged += new System.EventHandler(this.Salida_CheckedChanged);
            // 
            // inmueble2
            // 
            this.inmueble2.AutoSize = true;
            this.inmueble2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.inmueble2.Location = new System.Drawing.Point(2, 627);
            this.inmueble2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inmueble2.Name = "inmueble2";
            this.inmueble2.Size = new System.Drawing.Size(35, 13);
            this.inmueble2.TabIndex = 42;
            this.inmueble2.Text = "label4";
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 693);
            this.Controls.Add(this.inmueble2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.Controls.SetChildIndex(this.Picture, 0);
            this.Controls.SetChildIndex(this.Entrada, 0);
            this.Controls.SetChildIndex(this.SalidaComida, 0);
            this.Controls.SetChildIndex(this.RegresoComida, 0);
            this.Controls.SetChildIndex(this.Salida, 0);
            this.Controls.SetChildIndex(this.inmueble2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label inmueble2;
    }
}