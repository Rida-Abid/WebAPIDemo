using System;
using System.Linq;
using System.Collections.Generic; 

namespace WebAPI.Controllers
{
    public class Demo
    {
        public Demo()
        {
             
            
        }
        public async Task<string> call(string url, string key, string host) 
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
                Headers =
                {
                        { "X-RapidAPI-Key", key },
                        { "X-RapidAPI-Host", host },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }

        }

    }

}
