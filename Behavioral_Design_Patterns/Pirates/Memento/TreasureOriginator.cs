using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Memento
{
    // Клас, що відповідає за створення та відновлення моментів запису (Memento)
    public class TreasureOriginator
    {
        private TreasureMemento location;

        public TreasureOriginator(string location)
        {
            this.location = new TreasureMemento(location);
        }

        public TreasureMemento CreateMemento()
        {
            return new TreasureMemento(location.Location);
        }

        public void SetMemento(TreasureMemento memento)
        {
            location = memento;
        }
    }
}
