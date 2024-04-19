using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Composite
{
    public interface IMaterialComponent
    {
        void Add(MaterialComponent component);
        void Display(int depth);
        double GetTotalWeight();
    }
}
