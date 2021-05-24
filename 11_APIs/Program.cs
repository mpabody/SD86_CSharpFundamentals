using _11_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_APIs
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            Person person = response.Content.ReadAsAsync<Person>().Result;
            Console.WriteLine(person.Name);

            Console.WriteLine($"{person.Name} has {person.Hair_Color} hair.");

            foreach (string vehicleUrl in person.Vehicles)
            {
                HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
                //Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result);
                Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                Console.WriteLine(vehicle.Name);
            }

            SWAPIService swapiService = new SWAPIService();

            Person personTwo = swapiService.GetPersonAsync(5).Result;
            if (personTwo != null)
            {
                Console.WriteLine(personTwo.Name);

                foreach(string vehicleUrl in personTwo.Vehicles)
                {
                    Vehicle vehicle = swapiService.GetVehicleAsync(vehicleUrl).Result;
                    Console.WriteLine(vehicle.Name);
                }
            }

            Vehicle genericResponse = swapiService.GetAsync<Vehicle>("https://swapi.dev/api/vehicles/4").Result;
            if (genericResponse != null)
            {
                Console.WriteLine(genericResponse.Name);
            }
            else
                Console.WriteLine("No vehicle exists here");


            SearchResult<Person> skywalkers = swapiService.GetPersonSearchAsync("Skywalker").Result;
            Console.WriteLine(skywalkers.Count);
            foreach(Person personResult in skywalkers.Results)
            {
                Console.WriteLine(personResult.Name);
            }

            SearchResult<Vehicle> starfighters = swapiService.GetVehicleSearchAsync("starfighter").Result;
            Console.WriteLine(starfighters.Count);
            foreach(Vehicle vehicleResult in starfighters.Results)
            {
                Console.WriteLine(vehicleResult.Name);
            }

            Console.ReadKey();
        }
    }
}
