using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Strategy
{
    public class MassiveAttackStrategy : ICombatStrategy
    {
        public void ExecuteStrategy()
        {
            Console.WriteLine("Pirate crew launches a massive attack.");
            // Додаткові дії для масштабної атаки
        }
    }
}