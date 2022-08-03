using Refit;

namespace Exercicio8
{
    public interface IMarvelApiService
    {
        [Get("/v1/public/comics?ts={timestamp}&apikey={pubKey}&hash={hash}")]
        Task<MarvelResponse> GetAddressAsync(string timestamp, string pubKey, string hash);
    }
}
