using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    public class DataServiceStarships
    {
        public static async Task<Starships> GetStarWarsStarships(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Starships data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Starships>(response);
                return data;
            }
            return null;
        }
    }
}
