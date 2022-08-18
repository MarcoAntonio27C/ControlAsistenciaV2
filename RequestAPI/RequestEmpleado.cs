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
    }
}
