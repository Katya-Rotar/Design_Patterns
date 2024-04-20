using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Observer
{
    // Піратський спостерігач, який отримує оновлення про зміни погоди
    public class PirateObserver : IObserver
    {
        public void Update(WeatherData data)
        {
            // Реакція піратів на зміни погоди
            Console.WriteLine($"Pirates react to weather changes: Temperature - {data.Temperature}, Wind Direction - {data.WindDirection}, Precipitation - {data.Precipitation}, Cloudiness - {data.Cloudiness}");
        }
    }

}