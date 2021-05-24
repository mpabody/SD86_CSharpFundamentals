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
                Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result);
            }

            Console.ReadKey();
        }
    }
}
