using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Strategy
{
    public class HitAndRunStrategy : ICombatStrategy
    {
        public void ExecuteStrategy()
        {
            Console.WriteLine("Pirate crew executes hit and run tactics.");
            // Дії для швидкого нападу і втечі
        }
    }
}