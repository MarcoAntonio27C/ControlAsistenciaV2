
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
            this.inmueble2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Asistencia";
            this.Controls.SetChildIndex(this.Entrada, 0);
            this.Controls.SetChildIndex(this.SalidaComida, 0);
            this.Controls.SetChildIndex(this.RegresoComida, 0);
            this.Controls.SetChildIndex(this.Salida, 0);
            this.Controls.SetChildIndex(this.inmueble2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label inmueble2;
    }
}