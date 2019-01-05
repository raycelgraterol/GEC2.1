using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GECApi
{
    public class HttpClientServices
    {
        private string securityServer { get; set; } = "https://localbitcoins.com/";

        public async Task<string> PostUnAuthorized(string requestString, string postBody)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");


                var response = client.PostAsync(securityServer + requestString,
                    new StringContent(postBody, Encoding.UTF8)).Result;
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<string> GetUnAuthorized(string requestString)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");


                var response = client.GetAsync(securityServer + requestString).Result;
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task<string> GetAuthorized(string token, string requestString)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);


                var response = client.GetAsync(securityServer + requestString).Result;
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                throw new Exception(response.RequestMessage.Content.ToString());
            }
        }
        public async Task<bool> DeleteAuthorized(string token, string requestString)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);


                var response = await client.DeleteAsync(securityServer + requestString);
                if (response.IsSuccessStatusCode)
                {
                    return response.IsSuccessStatusCode;
                }
                throw new Exception(response.RequestMessage.Content.ToString());
            }
        }
    }
}
