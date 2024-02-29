using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Builder_Pattern
{
    public class Order
    {
        public List<PizzaItem> OrderedItems { get; set; }

        public Order()
        {
            OrderedItems = new List<PizzaItem>();
        }
        public void AddPizzaToOrder(PizzaItem pizza)
        {
            OrderedItems.Add(pizza);
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach (var item in OrderedItems)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
