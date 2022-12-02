using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WebAPI
{
    public class Demo
    {
        
        public async Task<string> Call(string url, string key, string host) 
        {


            if (!Regex.Match(url, @"^(http[s]?:\/\/)?([\w]{8}\-[\w]{5}\-[\w]{8}\-[\w]{4}\-[\w]{6}\.[\w]\.[\w]{8}\.[\w]{3})+(\/[\w]{3}\/[\w]{3}\-3)?$").Success)
            {
                return "Enter a valid URL";
            }
            if (!Regex.Match(host, @"^([\w]{8}\-[\w]{5}\-[\w]{8}\-[\w]{4}\-[\w]{6}\.[\w]\.[\w]{8}\.[\w]{3})+(\/[\w]{3})?$").Success)
            {
                return "Enter a valid Host";
            }

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

