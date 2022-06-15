using Newtonsoft.Json;
using snt_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace snt_task.Services
{

    public class Api
    {



        public List<Stock> GetStock()
        {
            var stocks = new List<Stock>();

            string result = string.Empty;
            var client = new HttpClient();

            HttpResponseMessage response = client.GetAsync("http://178.251.43.250:1204/Ideal/GetCandleData?symbol=garan&period=1&count=10").Result;
            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
                stocks = JsonConvert.DeserializeObject<List<Stock>>(result);
            }

            return stocks;
        }
    }


}
