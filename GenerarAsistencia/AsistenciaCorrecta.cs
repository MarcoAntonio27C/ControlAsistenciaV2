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
            this.timer1.Interval = 2400;
            this.timer1.Start();
            this.timer1.Tick += (o, e) =>
            {

                this.Hide();
            };
        }

        public void SetLabel(string nombre)
        {
            this.labelNombre.Text = nombre;


        }



    }
}
