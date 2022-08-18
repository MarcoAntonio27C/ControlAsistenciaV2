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
    public partial class CapturarHuella : Form
    {
        RequestEmpleado requestEmpleado;
        public CapturarHuella()
        {
            InitializeComponent();
            requestEmpleado = new RequestEmpleado();
            NombreCompleto.Enabled = false;
            FechaIngreso.Enabled = false;
            Cargo.Enabled = false;

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
                    
                    var empleado = JsonConvert.DeserializeObject<Empleado>(request.Content);
                    if (!empleado.Equals(null))
                    {
                        NombreCompleto.Text = empleado.Nombre + " " + empleado.ApellidoPaterno + " " + empleado.ApellidoMaterno;
                        FechaIngreso.Text = empleado.FechaIngreso;
                    }
                }
                else
                {
                    NombreCompleto.Text = "";
                    FechaIngreso.Text = "";
                    MessageBox.Show("No se encontraron registros con ese Curp");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el CURP del empleado");
            }
        }
    }
}
