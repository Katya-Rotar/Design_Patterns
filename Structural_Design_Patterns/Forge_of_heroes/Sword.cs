using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes
{
    public class Sword
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Attack { get; set; }

        public Sword(string name, double weight, int attack)
        {
            Name = name;
            Weight = weight;
            Attack = attack;
        }

        public override string ToString()
        {
            return $"{Name}" +
                $"\nWeight: {Weight}" +
                $"\nAttack: {Attack}";
        }
    }
}