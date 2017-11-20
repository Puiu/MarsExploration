using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MeasurementSources.Tests
{
    [TestClass]
    public class SoilAnalyzerTests
    {
        [TestMethod]
        public async Task DoMeasureAsync_ExpectedNotNull()
        {
            var analyzer = new SoilAnalyzer();

            var model = await analyzer.DoMeasureAsync();

            Assert.IsNotNull(model);
            
        }
    }
}
