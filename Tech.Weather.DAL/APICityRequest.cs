using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
// /////https://api.weatherapi.com/v1/current.json?key=b480e7a490374b44be472511222103&q=JERUSALEM&aqi=no%22
namespace Tech.Weather.DAL
{
    public class APICityRequest
    {
        public async Task<string> GetCityData(string cityname)
        {
            string str = "";
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri("https://api.weatherapi.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method
                HttpResponseMessage response = await  client.GetAsync(@"/v1/current.json?key=b480e7a490374b44be472511222103&q="+cityname+"&aqi=no%22");
                if (response.IsSuccessStatusCode)
                {
                    str = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }

            }   
            
            return str;
        }
    }
}
