using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Chain_of_Responsibility
{
    // Клас, що представляє запит
    public class Request
    {
        public string Type { get; set; }

        public Request(string type)
        {
            Type = type;
        }
    }
}
