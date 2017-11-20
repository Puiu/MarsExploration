using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IHeaderHelper
    {
        string GetAppVersion();
        string TryGetLocalIPAddress();
        Task<string> TryGetExternalIPAddressAsync();
    }
}
