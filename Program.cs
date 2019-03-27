using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using StarWarsAPIClient.Client;
using StarWarsAPIClient.DataBase;

namespace StarWarsAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StarWarsClient();
            var result = client.GetContent("planets/13");
            var planeta = JsonConvert.DeserializeObject<PlanetModel>(result);
            System.Console.WriteLine(planeta.Name);
            System.Console.WriteLine(planeta.Gravity);
            foreach(var film in planeta.Films){
                System.Console.WriteLine(film);
            }
            //JsonConvert.DeserializeAnonymousType(response.Content, (new {count = 0, next = "", results = new List<PlanetModel>()}));


        }
    }
}
