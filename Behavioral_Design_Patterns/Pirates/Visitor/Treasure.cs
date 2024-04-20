using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Visitor
{
    public class Treasure : InventoryItem
    {
        public List<string> Treasures { get; set; }
        public Treasure(List<string> treasures) {
            this.Treasures = treasures;
        }
        public override void Accept(IInventoryVisitor visitor)
        {
            visitor.VisitTreasure(this);
        }
    }
}