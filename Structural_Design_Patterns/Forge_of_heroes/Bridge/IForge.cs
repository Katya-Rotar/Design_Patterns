using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Bridge
{
    public interface IForge
    {
        void HeatMetal(); //нагрівання
        void BeatMetal(); //биття
        void BendMetal(); //згинання
        void ShapeMetal(); //надання форми
        void PreparePattern(); //підготовка шаблоку
        void ApplyPattern(); // застосування шаблону
    }
}