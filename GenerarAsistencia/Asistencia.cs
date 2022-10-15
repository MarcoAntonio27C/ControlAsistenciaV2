using ControlAsistencia_.Models;
using Newtonsoft.Json;
using RequestAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerarAsistencia
{
    public partial class Asistencia : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification verificator;
        RequestEmpleado requestEmpleado;
        RequestAsistencia requestAsistencia;
        public string IdInmueble = "";
        public string NombreInmueble = "";

        public Asistencia()
        {
            InitializeComponent();
            requestEmpleado = new RequestEmpleado();
            requestAsistencia = new RequestAsistencia();

        }

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }

        protected override void Init()
        {
            base.Init();
            base.Text = "Verificacion de Huella Digital";
            verificator = new DPFP.Verification.Verification();
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("False Accep Rate (RAT) = {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            //Procese la muestra y cree un conjunto de características para fines de inscripción
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Verifique la calidad de la muestra y comience la verificación si es buena
            // TODO: pasar a una tarea separada
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;

                try
                {
                    var res = requestEmpleado.EmpleadosPorInmueble(IdInmueble);

                    if (!res.Equals(null) && res.IsSuccessful.Equals(true))
                    {

                        var empleados = JsonConvert.DeserializeObject<List<Empleado>>(res.Content);

                        bool found = false;
                        foreach (var empleado in empleados)
                        {
                            byte[] huella = Convert.FromBase64String(Convert.ToBase64String(empleado.Huella));
                            stream = new MemoryStream(huella);
                            template = new DPFP.Template(stream);
                            verificator.Verify(features, template, ref result);
                            UpdateStatus(result.FARAchieved);

                            if (result.Verified)
                            {
                                ControlAsistencia_.Models.Asistencia asistencia = new ControlAsistencia_.Models.Asistencia();
                                asistencia.Id = Guid.NewGuid();
                                asistencia.IdEmpleado = empleado.Id;
                                asistencia.Tipo = tipoEntrada();
                                asistencia.FechaHora = DateTime.Now;
                                found = true;

                                if (!tipoEntrada().Equals(""))
                                {
                                    var peticion = requestAsistencia.AddAsistencia(asistencia);

                                    if (!peticion.Equals(null))
                                    {
                                        if (peticion.IsSuccessful)
                                        {

                                            MessageBox.Show(empleado.Nombre + " " + empleado.ApellidoPaterno + " " + empleado.ApellidoMaterno + " se Registro su Asistencia Correctamente");
                                            Picture.Image = global::GenerarAsistencia.Properties.Resources.fondoBlanco;
                                            break;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al intentar guardar su asistencia, intentelo nuevamente");
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error al intentar conectarse con el servicio de Biometricos");
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Seleccione el Tipo de Asistencia");
                                    break;
                                }
                            }

                        }


                        if (found == false)
                        {
                            MessageBox.Show("Usuario no encontrado, intentelo de nuevo por favor");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al consultar la información");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex);
                }
            }
        }


        private String tipoEntrada()
        {
            if (Entrada.Checked){return "Entrada";}
            if (SalidaComida.Checked){return "SalidaComida";}
            if (RegresoComida.Checked){return "RegresoComida";}
            if (Salida.Checked){return "Salida";}
            return "";
        }

        public void SetInmueble(ComboboxValue comboBoxValue)
        {
            IdInmueble = comboBoxValue.Id.ToString();
            NombreInmueble = comboBoxValue.Name;
            inmueble2.Text = NombreInmueble;
        }
    }
}
