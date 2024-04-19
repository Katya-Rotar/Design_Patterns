using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Memento
{
    public class TreasureCaretaker
    {
        public List<TreasureMemento> mementoList = new List<TreasureMemento>();

        public void AddMemento(TreasureMemento memento) {
            mementoList.Add(memento);
        }

        public TreasureMemento GetMemento(int index) { 
            return mementoList[index]; 
        }
    }
}
