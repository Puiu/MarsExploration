using Microsoft.Azure.Devices.Client;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IDeviceToCloudMessageHandler<T> : IMeasureHandler<T>
    {
        Message GetMessageFromMeasure(T measure);
        Task SendDeviceToCloudMessageAsync(Message message);
    }
}
