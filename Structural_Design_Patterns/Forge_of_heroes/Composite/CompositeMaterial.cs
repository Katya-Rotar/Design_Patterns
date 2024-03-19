using Structural_Design_Patterns.Forge_of_heroes.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Composite
{
    class CompositeMaterial : MaterialComponent, IMaterialComponent
    {
        public List<MaterialComponent> children = new List<MaterialComponent>();

        public CompositeMaterial(string name, double weigth) : base(name, 0)
        {
        }

        public void Add(MaterialComponent component)
        {
            children.Add(component);
            weight += component.GetWeight();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (MaterialComponent component in children)
            {
                component.Display(depth + 1);
            }
        }

        public double GetTotalWeight()
        {
            double totalWeight = 0;
            foreach (MaterialComponent component in children)
            {
                totalWeight += component.GetWeight();
            }
            return totalWeight;
        }
    }
}
