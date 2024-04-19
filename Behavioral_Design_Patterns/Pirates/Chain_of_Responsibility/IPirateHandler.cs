using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Chain_of_Responsibility
{
    public interface IPirateHandler
    {
        // Інтерфейс для обробників
        void HandleRequest(Request request);
        void SetNextHandler(IPirateHandler nextHandler);
    }
}
