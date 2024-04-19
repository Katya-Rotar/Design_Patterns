using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Memento
{
    public class TreasureMemento
    {
        public string Location { get; set; }
        public TreasureMemento(string location) {
            Location = location;
        }
    }
}
