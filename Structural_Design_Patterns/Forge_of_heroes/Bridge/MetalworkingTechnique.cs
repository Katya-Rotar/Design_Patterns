using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Bridge
{
    public abstract class MetalworkingTechnique
    {
        public IForge forge;
        public MetalworkingTechnique(IForge forge)
        {
            this.forge = forge;
        }

        public abstract void ProcessMetal();
    }
}