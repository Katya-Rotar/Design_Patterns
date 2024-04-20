using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Observer
{
    // Клас, що містить дані про погоду
    public class WeatherData
    {
        public float Temperature { get; set; } //температура
        public string WindDirection { get; set; } //напрямок вітру
        public string Precipitation { get; set; } // опади
        public float Cloudiness { get; set; } // хмарність
    }
}