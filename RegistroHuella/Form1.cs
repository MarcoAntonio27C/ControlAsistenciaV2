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

namespace RegistroHuella
{
    public partial class Form1 : Form
    {
        RequestInmueble requestInmueble;

        public Form1()
        {
            InitializeComponent();
            requestInmueble = new RequestInmueble();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var request = requestInmueble.Inmuebles();
            if(!request.Equals(null) && (!request.IsSuccessful.Equals(false)))
            {
                var Inmuebles = JsonConvert.DeserializeObject<List<Inmueble>>(request.Content);

                foreach(var inmueble in Inmuebles)
                {
                    ComboBoxInmueble.Items.Add(inmueble.Nombre);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ComboBoxInmueble.SelectedIndex.ToString());
            MessageBox.Show(ComboBoxInmueble.SelectedIndex.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
