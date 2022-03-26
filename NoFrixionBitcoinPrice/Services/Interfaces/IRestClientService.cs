using System.Threading.Tasks;

namespace NoFrixionBitcoinPrice.Services.Interfaces
{
    public interface IRestClientService
    {
        Task<TResult> GetAsync<TResult>(string url);
    }
}
