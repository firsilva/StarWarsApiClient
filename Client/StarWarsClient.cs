using Newtonsoft.Json;
using RestSharp;

namespace StarWarsAPIClient.Client
{
    public class StarWarsClient
    {
        public string GetContent(string endPoint){
            var client = new RestClient($"https://swapi.co/api/{endPoint}");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            return response.Content;
        }
    }
}