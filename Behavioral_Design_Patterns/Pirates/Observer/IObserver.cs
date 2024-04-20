using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Observer
{
    // Інтерфейс спостерігача
    public interface IObserver
    {
        void Update(WeatherData data);
    }
}
