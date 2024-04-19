using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Mediator
{
    public class Pirate
    {
        private string _name;
        private ShipMediator _mediator;

        public Pirate(string name, ShipMediator mediator)
        {
            _name = name;
            _mediator = mediator;
        }

        // Метод для надсилання повідомлення іншим членам екіпажу через посередника
        public void Send(string recipient, string message)
        {
            _mediator.SendMessage(_name, recipient, message);
        }

        // Метод для отримання загального повідомлення через посередника
        public void ReceiveBroadcast(string message) 
        {
            Console.WriteLine($"[{_name}] received broadcast message: '{message}'");
        }
    }
}
