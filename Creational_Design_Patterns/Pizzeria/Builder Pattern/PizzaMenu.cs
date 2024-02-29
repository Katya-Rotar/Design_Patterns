using Pizzeria.Factory_Pattern.Meat_Ingredient;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.PizzaAvailable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Builder_Pattern
{
    public class PizzaMenu
    {
        public List<PizzaItem> MenuItems;

        public PizzaMenu() {
            MenuItems = new List<PizzaItem>();
            
            MenuItems.Add(new PizzaItem { Name = ClassicPizza.GetPizzaName(), Price = 200});
            MenuItems.Add(new PizzaItem { Name = PepperoniPizza.GetPizzaName(), Price = 240});
            MenuItems.Add(new PizzaItem { Name = CapricciosaPizza.GetPizzaName(), Price = 225 });
        }
    }
}
