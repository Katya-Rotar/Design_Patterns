using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Strategy
{
    public class StealthStrategy : ICombatStrategy
    {
        public void ExecuteStrategy()
        {
            Console.WriteLine("Pirate crew employs stealth tactics.");
            // Дії для Стелс-стратегії
        }
    }
}