using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Bridge
{
    public class ColdForging : MetalworkingTechnique
    {
        public ColdForging(IForge forge) : base(forge) { }

        public override void ProcessMetal()
        {
            forge.BendMetal();//згинання
            forge.ShapeMetal();//надання форми
        }
    }
}