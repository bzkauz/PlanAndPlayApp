using Models;
using System;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Services
{
    public class WebService : IWebData
    {
        public async Task<Earthquake[]> GetEarthquakesAsync()
        {

            var client = new System.Net.Http.HttpClient();

            client.BaseAddress = new Uri("http://api.geonames.org/");

            var response = await client.GetAsync("earthquakesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&username=bertt&maxRows=20");

            var earthquakesJson = response.Content.ReadAsStringAsync().Result;

            var rootobject = JsonConvert.DeserializeObject<RootobjectE>(earthquakesJson);

            return rootobject.earthquakes;

        }

        public Task<Object> GetPlanAndPlayt()
        {
            var client = new System.Net.Http.HttpClient();
            //var response = await client.GetStringAsync("earthquakesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&username=bertt&maxRows=20");
            //var earthquakesJson = response.Content.ReadAsStringAsync().Result;

            //var rootobject = JsonConvert.DeserializeObject<RootobjectE>(earthquakesJson);
            Object oo = new Object();
            return null;
        }
    }
}
