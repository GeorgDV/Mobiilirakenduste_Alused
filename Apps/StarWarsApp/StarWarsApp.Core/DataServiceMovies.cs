using Newtonsoft.Json;
using StarWarsApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsApp.Core
{
    public class DataServiceMovies
    {
        public static async Task<Movies> GetStarWarsMovies(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            Movies data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<Movies>(response);
                return data;
            }
            return null;
        }
    }
}
