using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NoFrixionBitcoinPrice.Services.Interfaces;

namespace NoFrixionBitcoinPrice.Services
{
    public class RestClientService : IRestClientService
    {
        private static readonly HttpClient client = new HttpClient();

        public RestClientService()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Console - NoFrixion (PMaldonado)");
        }

        public async Task<TResult> GetAsync<TResult>(string url)
        {
            string plainResult = await client.GetStringAsync(url);

            TResult response = JsonConvert.DeserializeObject<TResult>(plainResult);

            return response;
        }
    }
}
