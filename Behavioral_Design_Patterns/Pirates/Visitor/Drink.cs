using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Visitor
{
    public class Drink : InventoryItem
    {
        public List<string> Drinks {  get; set; }
        public Drink(List<string> drinks) {
            this.Drinks = drinks;
        }
        public override void Accept(IInventoryVisitor visitor)
        {
           visitor.VisitDrink(this);
        }
    }
}