using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Visitor
{
    public class Weapon : InventoryItem
    {
        public List<string> Weapons { get; set; }
        public Weapon(List<string> weapons) {
            this.Weapons = weapons;
        }
        public override void Accept(IInventoryVisitor visitor)
        {
            visitor.VisitWeapon(this);
        }
    }
}