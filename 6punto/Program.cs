using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TaxiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var url = "http://taxisws.widetech.co/API/rest/CabSimpleResponse";

                var requestBody = new
                {
                    GP = new[]
                    {
                        new { Name = "USR", Value = "taxi" },
                        new { Name = "PASS", Value = "taxi" },
                        new { Name = "CLIENTEID", Value = "51776" },
                        new { Name = "METHOD", Value = "GETVEHICLETYPE" }
                    }
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    Console.WriteLine("Sending request to URL: " + url);
                    Console.WriteLine("Request content: " + json);

                    var response = await client.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();

                    var responseString = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("Response:");
                    Console.WriteLine(responseString);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Request error: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}

