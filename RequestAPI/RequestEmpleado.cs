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
        //string API = "https://localhost:44396/api/";
        string API = "http://10.24.1.29/PeopleSearch/Api/";


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
                var client = new RestClient(API + "Empleado/Actualizar");
                var request = new RestRequest("", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(new
                {
                    id= $"{empleado.Id}",
                    nombreCompleto = $"{empleado.NombreCompleto}",
                    numeroExpediente = $"{empleado.NumeroExpediente}",
                    fechaIngreso = $"{empleado.FechaIngreso}",
                    ur = $"{empleado.UR}",
                    horario = $"{empleado.Horario}",
                    huella = $"{huella}",
                    idMunicipio = $"{empleado.IdMunicipio}",
                    idInmueble = $"{empleado.IdInmueble}",
                    idCargo = $"{empleado.IdCargo}",
                    //idCargoHomologado = $"{empleado.IdCargoHomologado}",
                    idCentroTrabajo = $"{empleado.IdCentroTrabajo}",
                    idUnidadAdministrativa = $"{empleado.IdUnidadAdministrativa}",
                    idContratacion = $"{empleado.IdContratacion}"
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
