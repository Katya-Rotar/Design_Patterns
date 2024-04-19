using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Mediator
{
    // Клас, що представляє посередника (медіатора) - помічник капітана
    public class ShipMediator
    {
        // Метод для відправлення повідомлення від одного члена екіпажу до іншого через посередника
        public void SendMessage(string sender, string recipient, string message)
        {
            Console.WriteLine($"[{sender}] sends message to [{recipient}]: '{message}'");
        }
        // Метод для відправлення загального повідомлення всьому екіпажу
        public void BroadcastMessage(string message) {
            Console.WriteLine($"[Broadcast] Message to all: '{message}'");
        }
    }
}
