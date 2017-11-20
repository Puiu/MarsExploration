using Microsoft.Extensions.Logging;

namespace Infrastructure.Abstractions
{
    /// <summary>
    /// Used for mocking in the TestStubs project
    /// </summary>
    public interface IMarsExplorationLogging<T> : ILogger<T>
    {
    }
}
