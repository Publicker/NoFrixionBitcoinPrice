using System;
using System.Threading.Tasks;
using NoFrixionBitcoinPrice.Models;
using NoFrixionBitcoinPrice.Services;
using NoFrixionBitcoinPrice.Utils;

namespace NoFrixionBitcoinPrice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RestClientService restClientService = new RestClientService();

            CurrentPriceResponseDTO currentPriceResponse = await restClientService.GetAsync<CurrentPriceResponseDTO>($"{Constants.CoinDeskEndpoint}/bpi/currentprice.json");

            Console.WriteLine($"BTC Price EUR {currentPriceResponse.Bpi.EUR.Rate}.");
        }
    }
}
