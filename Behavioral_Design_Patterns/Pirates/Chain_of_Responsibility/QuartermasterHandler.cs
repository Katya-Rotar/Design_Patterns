using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Chain_of_Responsibility
{
    //Квартермейстер
    public class QuartermasterHandler : IPirateHandler
    {
        private IPirateHandler? _nextHandler;
        public void HandleRequest(Request request)
        {
            if (request.Type == "Nautical Charts")
            {
                //запит на надання морських карт
                Console.WriteLine("Quartermaster is processing a request to provide sea charts.");
            }
            else if (_nextHandler != null)
            {
                //наступному
                Console.WriteLine("The quartermaster passes the request to the next in the chain.");
                _nextHandler.HandleRequest(request);
            }
            else
            {
                //не може бути оброблений
                Console.WriteLine("The request cannot be processed.");
            }
        }

        public void SetNextHandler(IPirateHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
    }
}
