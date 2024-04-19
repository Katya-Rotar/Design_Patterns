using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Bridge
{
    public class DesignForging : MetalworkingTechnique
    {
        public DesignForging(IForge forge) : base(forge) { }
        public override void ProcessMetal()
        {
            forge.PreparePattern();
            forge.ApplyPattern();
        }
    }
}