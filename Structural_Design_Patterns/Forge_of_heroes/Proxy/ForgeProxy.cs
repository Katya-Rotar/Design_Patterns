using Structural_Design_Patterns.Forge_of_heroes.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Proxy
{
    public class ForgeProxy : IForgeProxy
    {
        private ForgeFacade forge;
        private bool userHasPermission;

        public ForgeProxy(ForgeFacade forge, bool userHasPermission) {
            this.forge = forge;
            this.userHasPermission = userHasPermission;
        }

        public void ModifyItem(string swordName, int attackBonus, string featureName)
        {
            if (userHasPermission)
            {
                forge.ModifyItem(swordName, attackBonus, featureName);
            }
            else {
                Console.WriteLine("User does not have permission to modify items.");
            }
        }
    }
}
