using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestAPI
{
    public class RequestMunicipio
    {

        //string API =  "https://localhost:44396/api/";
        //string API = "http://10.24.1.29/PeopleSearch/Api/";

        //PRODUCCION
        string API = "http://10.24.1.45/RH-Fiscalia/Api/";
        public IRestResponse Municipios()
        {
            try
            {
                var client = new RestClient(API+ "Municipio");
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
