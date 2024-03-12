using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structural_Design_Patterns.Forge_of_heroes.Composite
{
    public class Gemstone : MaterialComponent
    {
        public Gemstone(string name, double weight) : base(name, weight) { }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name + " (" + weight + " г)");
        }
    }
}
