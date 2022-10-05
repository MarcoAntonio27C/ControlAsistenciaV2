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
        //string API = "http://10.24.1.29/PeopleSearch/Api/";
        public IRestResponse Inmuebles()
        {
            try
            {
                var client = new RestClient(API+ "Inmueble");
                //var client = new RestClient(API);
                var request = new RestRequest("", Method.GET);
                var response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IRestResponse InmueblesMunicipio(string idMunicipio)
        {
            try
            {
                var client = new RestClient(API + "Inmueble/Municipio/"+idMunicipio);
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
