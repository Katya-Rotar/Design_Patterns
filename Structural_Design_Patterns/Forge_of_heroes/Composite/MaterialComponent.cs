using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Composite
{
    public abstract class MaterialComponent
    {
        public string name;
        public double weight;
        public MaterialComponent(string name, double weight) {
            this.name = name;
            this.weight = weight;
        }
        public abstract void Display(int depth);
        public double GetWeight() {
            return weight;
        }
    }
}
