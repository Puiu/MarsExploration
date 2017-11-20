using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IMeasureSource<T>
    {
        Task<T> DoMeasureAsync();
    }
}
