using Structural_Design_Patterns.Forge_of_heroes.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Proxy
{
    public class BlacksmithAssistantProxy : IForgeProxy
    {
        private ForgeFacade _facade;

        public BlacksmithAssistantProxy(ForgeFacade facade)
        {
            _facade = facade;
        }

        public void ModifyItem(string swordName, int attackBonus, string featureName)
        {
            if (attackBonus > 15)
            {
                Console.WriteLine($"The blacksmith assistant no permission");
            }
            else
            {
                _facade.ModifyItem(swordName, attackBonus, featureName);
            }
        }
    }
}
