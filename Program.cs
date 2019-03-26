using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using StarWarsAPIClient.DataBase;

namespace StarWarsAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://swapi.co/api/planets/");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);
            
            var planetas = JsonConvert.DeserializeObject<(new {results = new List<PlanetModel>()}))>(response.Content);
            
            foreach(var p in planetas.results){
                System.Console.WriteLine($"{p.name} rotation {p.rotation_period}");
            }
        }
    }
}
