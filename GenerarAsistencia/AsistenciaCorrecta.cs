using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerarAsistencia
{
    public partial class AsistenciaCorrecta : Form
    {
        public AsistenciaCorrecta()
        {
            InitializeComponent();
            this.timer1.Interval = 3000;
            this.timer1.Start();
            this.timer1.Tick += (o, e) =>
            {
                this.Close();
            };
        }

        public void SetLabel(string nombre)
        {
            labelNombre.Text = nombre;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AsistenciaCorrecta_Load(object sender, EventArgs e)
        {

        }
    }
}
