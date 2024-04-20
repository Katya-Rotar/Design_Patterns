using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Visitor
{
    public class Food : InventoryItem
    {
        public List<string> Foods {  get; set; }
        public Food(List<string> foods) {
            this.Foods = foods;
        }
        public override void Accept(IInventoryVisitor visitor)
        {
            visitor.VisitFood(this);
        }
    }
}