using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using StarWarsAPIClient.DataBase;

namespace StarWarsAPIClient.Client
{
    public class StarWarsClient
    {
        public static string GetByUrl(string URL){
            var client = new RestClient(URL);
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
        public static string GetByEndPoint(string endPoint){
            var client = new RestClient($"https://swapi.co/api/{endPoint}");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}