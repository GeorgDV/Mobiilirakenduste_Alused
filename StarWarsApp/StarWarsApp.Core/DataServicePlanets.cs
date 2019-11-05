using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    public class DataServicePlanets
    {
        public static async Task<Planets> GetStarWarsPlanets(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Planets data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Planets>(response);
            }
            return data;
        }
    }
}
