using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IMeasureHandler<T>
    {
        bool MustSaveMeasurementLocallyInCaseOfFailure { get; set; }
        
        Task HandleAsync(T measure);
    }
}
