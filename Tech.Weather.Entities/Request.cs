using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tech.Weather.DAL;

namespace Tech.Weather.Entities
{
    public class Request
    {
        public async static void GetCity(string cityName)
        {
            APICityRequest r = new APICityRequest();
            string  p = await r.GetCityData(cityName);
        }
    }
}
