using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Iterator
{
    public class PiratePortCollection : IEnumerable<PiratePort>
    {
        private List<PiratePort> _ports = new List<PiratePort>();

        // Метод для додавання порту до колекції
        public void AddPort(PiratePort port)
        {
            _ports.Add(port);
        }

        // Реалізація інтерфейсу IEnumerable
        public IEnumerator<PiratePort> GetEnumerator()
        {
            return _ports.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}