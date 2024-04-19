using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Iterator
{
    public class PiratePort
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public PiratePort(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
