using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using StarWarsAPIClient.Client;
using StarWarsAPIClient.DataBase;
using StarWarsAPIClient.DataBase.Planet;

namespace StarWarsAPIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetas = PlanetRepository.GetAll();
            foreach(var planeta in planetas){
                System.Console.WriteLine(planeta.Name);
            }
            //JsonConvert.DeserializeAnonymousType(response.Content, (new {count = 0, next = "", results = new List<PlanetModel>()}));


        }
    }
}
