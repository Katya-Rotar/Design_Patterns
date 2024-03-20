using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Decorator
{
    public class SwordDecorator : Sword, ISwordDecorator
    {
        private Sword sword;
        private string featureName;
        public SwordDecorator(Sword sword) : base(sword.Name, sword.Weight, sword.Attack)
        {
            this.sword = sword;
        }

        public int AddFeature(int attackBonus, string featureName)
        {
            Attack += attackBonus;
            this.featureName = featureName;
            Console.WriteLine($"Added feature: {featureName}. Increased attack by {attackBonus}");
            return Attack;
        }
    }
}
