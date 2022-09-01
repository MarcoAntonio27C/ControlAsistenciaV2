using ControlAsistencia_.Models;
using Newtonsoft.Json;
using RequestAPI;
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
    public partial class Inicio : Form
    {
        RequestInmueble requestInmueble;
        RequestMunicipio requestMunicipio;

        public Inicio()
        {
            InitializeComponent();
            requestInmueble = new RequestInmueble();
            requestMunicipio = new RequestMunicipio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var request = requestMunicipio.Municipios();
            if (!request.Equals(null) && (!request.IsSuccessful.Equals(false)))
            {
                var Municipios = JsonConvert.DeserializeObject<List<Municipio>>(request.Content);
                foreach (var municipio in Municipios)
                {
                    ComboBoxMunicipio.Items.Add(new ComboboxValue(municipio.Id, municipio.Nombre));
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ComboBoxInmueble.SelectedIndex != -1)
            {
                ComboboxValue comboboxValue = (ComboboxValue)ComboBoxInmueble.SelectedItem;

                Asistencia asistencia = new Asistencia();
                asistencia.SetInmueble(comboboxValue);
                asistencia.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún inmueble");
            }
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxMunicipio.SelectedIndex != -1)
            {
                ComboBoxInmueble.Items.Clear();
                ComboBoxInmueble.Text = "";
                ComboboxValue comboboxValue = (ComboboxValue)ComboBoxMunicipio.SelectedItem;
                var request = requestInmueble.InmueblesMunicipio(comboboxValue.Id.ToString());

                if (!request.Equals(null) && (!request.IsSuccessful.Equals(false)))
                {
                    var Inmuebles = JsonConvert.DeserializeObject<List<Inmueble>>(request.Content);

                    foreach (var inmueble in Inmuebles)
                    {
                        ComboBoxInmueble.Items.Add(new ComboboxValue(inmueble.Id, inmueble.Nombre));
                    }
                }
            }
        }
    }
}
