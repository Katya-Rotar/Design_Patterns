using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Observer
{
    // Клас, що представляє спостережуваний об'єкт - дані про погоду
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private WeatherData currentWeather;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(currentWeather);
            }
        }

        public void SetMeasurements(WeatherData weatherData) // поточна погода
        {
            currentWeather = weatherData;
            NotifyObservers();
        }
    }
}