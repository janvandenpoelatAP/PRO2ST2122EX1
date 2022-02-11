using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PRO2ST2021EX1
{
    public class KanyeApiService
    {
        public KanyeResponse KanyeQuote()
        {
            string url = "https://api.kanye.rest";

            using (var httpClient = new HttpClient())
            {
                var httpRespone = httpClient.GetAsync(url).GetAwaiter().GetResult();
                var response = httpRespone.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                return JsonConvert.DeserializeObject<KanyeResponse>(response);
            }
        }
    }
}
