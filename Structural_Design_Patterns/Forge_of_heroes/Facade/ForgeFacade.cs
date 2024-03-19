using Structural_Design_Patterns.Forge_of_heroes.Bridge;
using Structural_Design_Patterns.Forge_of_heroes.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Facade
{
    public class ForgeFacade
    {
        private Forge forge;

        public ForgeFacade(IMaterialComponent material)
        {
            this.forge = new Forge(material);
        }
        public void CreateItem(string nameSword, List<MaterialComponent> metal, List<MaterialComponent> wood, List<MaterialComponent> gemstone)
        {
            forge.Craft(nameSword, metal, wood, gemstone);
        }
        public void ModifyItem(string swordName, int attackBonus, string featureName) {
            forge.Modify(swordName, attackBonus, featureName);
        }
        public void ShowInventory() {
            forge.DisplayInventory();
        }
    }
}
