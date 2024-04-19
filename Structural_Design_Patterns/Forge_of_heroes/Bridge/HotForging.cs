using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Bridge
{
    public class HotForging : MetalworkingTechnique
    {
        public HotForging(IForge forge) : base(forge) { }
        public override void ProcessMetal()
        {
            forge.HeatMetal();//розігрівання
            forge.BendMetal();//биття
        }
    }
}