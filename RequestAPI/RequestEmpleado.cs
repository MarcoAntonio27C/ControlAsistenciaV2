using ControlAsistencia_.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestAPI
{
    public class RequestEmpleado
    {
        string API = "https://localhost:44396/api/";


        public IRestResponse EmpleadosPorInmueble(string idInmueble)
        {
            try
            {
                var client = new RestClient(API + "Empleado/EmpleadosPorInmueble/"+idInmueble);
                var request = new RestRequest("", Method.GET);
                var response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IRestResponse GetEmpleadoCurp(string CURP)
        {
            try
            {
                var client = new RestClient(API + "Empleado/CURP/"+CURP);
                var request = new RestRequest("", Method.GET);
                var response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IRestResponse UpdateEmpleado(Empleado empleado, string huella)
        {
            try
            {
                var client = new RestClient(API + "Empleado");
                var request = new RestRequest("", Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(new
                {
                    id= $"{empleado.Id}",
                    nombre = $"{empleado.Nombre}",
                    apellidoPaterno = $"{empleado.ApellidoPaterno}",
                    apellidoMaterno = $"{empleado.ApellidoPaterno}",
                    curp = $"{empleado.CURP}",
                    cargo = $"{empleado.Cargo}",
                    numeroExpediente = $"{empleado.NumeroExpediente}",
                    adscripcion = $"{empleado.Adscripcion}",
                    fechaIngreso = $"{empleado.FechaIngreso}",
                    huella = $"{huella}",
                    idInmueble = $"{empleado.IdInmueble}"
                });
                var response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
