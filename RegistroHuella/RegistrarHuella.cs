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
    public partial class RegistrarHuella : Form
    {
        private DPFP.Template Template;
        RequestEmpleado requestEmpleado;
        Empleado tmpEmpleado;
        string IdInmueble = "";
        string Inmueble = "";

        public RegistrarHuella()
        {
            InitializeComponent();
            tmpEmpleado = new Empleado();
            requestEmpleado = new RequestEmpleado();
            NombreCompleto.Enabled = false;
            FechaIngreso.Enabled = false;
            Registrar.Enabled = false;
            Curp.Enabled = false;
        }


        public void SetMunicipio(string idInmueble, string inmueble)
        {
            IdInmueble = idInmueble;
            Inmueble = inmueble;
            label_inmueble.Text = inmueble;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            bool found = false;
            if (!NumeroExpediente.Text.Equals(""))
            {
                var request = requestEmpleado.EmpleadosPorInmueble(IdInmueble);
                if (!request.Equals(null) && (!request.IsSuccessful.Equals(false)))
                {
                    var empleados = JsonConvert.DeserializeObject<List<Empleado>>(request.Content);
                    if (empleados.Count > 0)
                    {
                        foreach(var empleado in empleados)
                        {
                            if (empleado.NumeroExpediente.Equals(NumeroExpediente.Text) || empleado.Curp.Equals(NumeroExpediente.Text))
                            {
                                tmpEmpleado = empleado;
                                NombreCompleto.Text = empleado.NombreCompleto;
                                FechaIngreso.Text = empleado.FechaIngreso;
                                Curp.Text = empleado.Curp;
                                capturarHuell.Enabled = true;
                                Curp.Enabled = true;
                                found = true;
                                break;
                            }
                        }

                        if(found == false)
                        {
                            MessageBox.Show("No se encontraron registros");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay empleados registrados en este inmueble");
                    }
                }
                else
                {
                    NombreCompleto.Text = "";
                    FechaIngreso.Text = "";
                    Registrar.Enabled = false;
                    MessageBox.Show("Hubo algún problema con la conexión a la base de datos");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el Numero de Expediente del empleado");
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            byte[] streamHuella = Template.Bytes;
            string huella = Convert.ToBase64String(streamHuella);
            string curp = Curp.Text.ToUpper();

            var res = requestEmpleado.UpdateEmpleado(tmpEmpleado,curp ,huella);

            if (!res.Equals(null))
            {
                if (res.IsSuccessful)
                {
                    MessageBox.Show("Huella Guardada Correctamente");
                    NumeroExpediente.Text = "";
                    NombreCompleto.Text = "";
                    capturarHuell.Image = global::RegistroHuella.Properties.Resources.baseline_fingerprint_black_48dp;
                    FechaIngreso.Text = "";
                    capturarHuell.Enabled = false;
                    Registrar.Enabled = false;
                    Curp.Enabled = false;
                    Curp.Text = "";
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar la información");
                }
            }
        }

        private void capturarHuell_Click(object sender, EventArgs e)
        {
            CapturarHuella capturarHuella = new CapturarHuella();
            capturarHuella.OnTemplate += this.OnTemplate;
            capturarHuella.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                Registrar.Enabled = (Template != null);
                if (Template != null)
                {
                    capturarHuell.Image = global::RegistroHuella.Properties.Resources.huellaCorrecta;
                    MessageBox.Show("Huella Capturada Correctamente");
                }
                else
                {
                    MessageBox.Show("Algo ocurrio durante el registro de la huella, vuelva a repetir el proceso por favor");
                }
            }
            ));
        }

        private void RegistrarHuella_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Curp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
