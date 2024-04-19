using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Chain_of_Responsibility
{
    //Капітан
    public class CaptainHandler : IPirateHandler
    {
        private IPirateHandler? _nextHandler;
        public void HandleRequest(Request request)
        {
            if (request.Type == "Ship Maneuver") //маневр корабля
            {
                Console.WriteLine("The captain is processing a request to maneuver the ship");
            }
            else if (_nextHandler != null)
            { //передає запит наступному в ланцюгу
                Console.WriteLine("The captain passes the request to the next in the chain");
                _nextHandler.HandleRequest(request);
            }
            else {
                //запит не може бути оброблений
                Console.WriteLine("The request cannot be processed.");
            }
        }

        public void SetNextHandler(IPirateHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
    }
}
