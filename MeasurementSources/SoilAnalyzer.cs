using Infrastructure.Abstractions;
using Infrastructure.Models;
using System;
using System.Threading.Tasks;

namespace MeasurementSources
{
    public class SoilAnalyzer : IMeasureSource<SoilTelemetry>
    {
        public async Task<SoilTelemetry> DoMeasureAsync()
        {
            await Task.Delay(1000);

            var acidity = GetRandomNo();
            await Task.Delay(123);
            var humidity = GetRandomNo();
            await Task.Delay(132);
            var temp = GetRandomNo();
            var area = DetectArea();

            var model = new SoilTelemetry
            {
                Acidity = acidity,
                Area = area.ToString(),
                Date = DateTime.UtcNow,
                RowId = string.Format("{0:D19}", DateTime.MaxValue.Ticks - DateTime.UtcNow.Ticks).PadLeft(19, '0'),
                Humidity = humidity,
                Temperature = temp
            };

            return model;
        }

        private double GetRandomNo()
        {
            var nr = new Random(DateTime.Now.Millisecond);
            return nr.NextDouble();
        }

        private AreaEnum DetectArea()
        {
            Array values = Enum.GetValues(typeof(AreaEnum));
            Random random = new Random();
            AreaEnum randomArea = (AreaEnum)values.GetValue(random.Next(values.Length));
            return randomArea;
        }
    }
}
