using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Proxy
{
    public interface IForgeProxy
    {
        public void ModifyItem(string swordName, int attackBonus, string featureName);
    }
}
