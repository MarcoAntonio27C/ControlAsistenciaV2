using ControlAsistencia_.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestAPI
{
    public class RequestAsistencia
    {
        string API = "https://localhost:44396/api/";

        public IRestResponse AddAsistencia(Asistencia asistencia)
        {
            try
            {
                var client = new RestClient(API + "Asistencia");
                var request = new RestRequest("", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(new
                {
                    id = $"{asistencia.Id}",
                    idEmpleado = $"{asistencia.IdEmpleado}",
                    tipo = $"{asistencia.Tipo}",
                    fechaHora = $"{asistencia.FechaHora.ToString("yyyy-MM-ddTHH:mm:ss")}",
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
