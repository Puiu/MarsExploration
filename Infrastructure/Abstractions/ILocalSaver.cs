using System.Threading.Tasks;
using Windows.Storage;

namespace Infrastructure.Abstractions
{
    public interface ILocalSaver<T> : IMeasureHandler<T>
    {
        Task<StorageFolder> GetMeasurementsFolder();
    }
}
