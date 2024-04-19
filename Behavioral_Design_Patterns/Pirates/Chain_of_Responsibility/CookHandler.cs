using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Chain_of_Responsibility
{
    //Кок
    public class CookHandler : IPirateHandler
    {
        private IPirateHandler? _nextHandler;

        public void HandleRequest(Request request)
        {
            if (request.Type == "Food")
            {
                Console.WriteLine("Cook is processing a food request.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine("Cook passes the request to the next in the chain.");
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("The request cannot be processed.");
            }
        }

        public void SetNextHandler(IPirateHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
    }
}