using Structural_Design_Patterns.Forge_of_heroes.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Proxy
{
    public class BlacksmithProxy : IForgeProxy
    {
        private ForgeFacade _facade;

        public BlacksmithProxy(ForgeFacade facade) {
            _facade = facade;
        }
        public void ModifyItem(string swordName, int attackBonus, string featureName)
        {
            if (attackBonus < 10)
            {
                Console.WriteLine($"The blacksmith will not undertake this work");
            }
            else
            {
                _facade.ModifyItem(swordName, attackBonus, featureName);
            }
        }
    }
}
