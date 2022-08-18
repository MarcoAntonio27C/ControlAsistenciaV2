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
        Empleado empleado;
        public RegistrarHuella()
        {
            InitializeComponent();
            empleado = new Empleado();
            requestEmpleado = new RequestEmpleado();
            NombreCompleto.Enabled = false;
            FechaIngreso.Enabled = false;
            Cargo.Enabled = false;
            Registrar.Enabled = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetMunicipio(string municipio)
        {
            NombreMunicipio.Text = municipio;
            NombreMunicipio.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Curp.Text.Equals(""))
            {
                var request = requestEmpleado.GetEmpleadoCurp(Curp.Text);
                if (!request.Equals(null) && (!request.IsSuccessful.Equals(false)))
                {
                    
                     empleado = JsonConvert.DeserializeObject<Empleado>(request.Content);
                    if (!empleado.Equals(null))
                    {
                        NombreCompleto.Text = empleado.Nombre + " " + empleado.ApellidoPaterno + " " + empleado.ApellidoMaterno;
                        FechaIngreso.Text = empleado.FechaIngreso;
                        capturarHuell.Enabled = true;

                    }
                }
                else
                {
                    NombreCompleto.Text = "";
                    FechaIngreso.Text = "";
                    Registrar.Enabled = false;
                    MessageBox.Show("No se encontraron registros con ese Curp");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el CURP del empleado");
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            byte[] streamHuella = Template.Bytes;
            string huella = Convert.ToBase64String(streamHuella);

            var res = requestEmpleado.UpdateEmpleado(empleado, huella);

            if (!res.Equals(null))
            {
                if (res.IsSuccessful)
                {
                    MessageBox.Show("Huella Guardada Correctamente");
                    Curp.Text = "";
                    NombreCompleto.Text = "";
                    capturarHuell.Image = global::RegistroHuella.Properties.Resources.baseline_fingerprint_black_48dp;
                    Cargo.Text = "";
                    FechaIngreso.Text = "";
                    capturarHuell.Enabled = false;
                    Registrar.Enabled = false;
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


    }
}
