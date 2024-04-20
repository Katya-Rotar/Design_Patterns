using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Visitor
{
    public class InventoryPrinter : IInventoryVisitor
    {
        public void VisitDrink(Drink drink)
        {
            Console.Write("\nInspecting drink: ");
            foreach (string drinks in drink.Drinks) {
                Console.Write(drinks + "; ");
            }
            Console.WriteLine();
        }

        public void VisitFood(Food food)
        {
            Console.Write("\nInspecting food: ");
            foreach (string foods in food.Foods)
            {
                Console.Write(foods + "; ");
            }
            Console.WriteLine();
        }

        public void VisitTreasure(Treasure treasure)
        {
            Console.Write("\nInspecting treasure ");
            foreach (string treasures in treasure.Treasures) {
                Console.Write(treasures + "; ");
            }
            Console.WriteLine();
        }

        public void VisitWeapon(Weapon weapon)
        {
            Console.Write("\nInspecting weapon: ");
            foreach (string weapons in weapon.Weapons)
            {
                Console.Write(weapons + "; ");
            }
            Console.WriteLine();
        }
    }
}