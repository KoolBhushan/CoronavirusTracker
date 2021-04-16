using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoronovirusTracker.Models.Helpers
{
    public class CovidHelper
    {
        public const string BASE_URL = "https://api.rootnet.in/covid19-in/stats/latest";

        public static async Task<Covid> GetCovidDataAsync()
        {           
            string url = BASE_URL;

            using HttpClient client = new();
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Covid>(json);
        }
    }
}
