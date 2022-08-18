using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestAPI
{
    public class RequestInmueble
    {
        string API =  "https://localhost:44396/api/";

        public IRestResponse Inmuebles()
        {
            try
            {
                var client = new RestClient(API+ "Inmueble");
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
