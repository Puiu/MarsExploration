using System;

namespace Infrastructure.Models
{
    public class SoilTelemetry
    {
        public string Area { get; set; }

        public DateTime Date { get; set; }

        public string RowId { get; set; }

        public double Humidity { get; set; }

        public double Temperature { get; set; }

        public double Acidity { get; set; }

        public override string ToString()
        {
            return $"{Date.ToString("dd.MM.yyyy hh:mm:ss.fff")}: {Area.ToString()}; Hum: {Humidity}; Temp: {Temperature}; Acidity: {Acidity}"; 
        }
    }
}
