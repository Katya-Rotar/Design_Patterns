using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Observer
{
    // Інтерфейс спостережуваного об'єкта
    public interface ISubject
    {
        void RegisterObserver(IObserver observer); // Зареєструвати спостерігача
        void RemoveObserver(IObserver observer); // Видалити спостерігача
        void NotifyObservers(); // Повідомити спостерігачів
    }
}