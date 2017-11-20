using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IResender<T>
    {
        IMeasureHandler<T> Saver { get; set; }
        Task TryResendMeasuresAsync();
    }
}
