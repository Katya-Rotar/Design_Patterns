using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Strategy
{
    public class PirateCaptain
    {
        private ICombatStrategy combatStrategy;
        public void SetCombatStrategy(ICombatStrategy combatStrategy) {
            this.combatStrategy = combatStrategy;
        }
        public void ExecuteCombatStrategy() {
            combatStrategy.ExecuteStrategy();
        }
    }
}