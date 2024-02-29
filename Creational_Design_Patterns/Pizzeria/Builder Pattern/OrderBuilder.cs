using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Builder_Pattern
{
    // Клас для створення замовлення клієнта з використанням паттерну Builder
    public class OrderBuilder
    {
        Order order = new Order();

        public OrderBuilder AddPizza(PizzaItem pizza) {
            order.AddPizzaToOrder(pizza);
            return this;
        }
        // повернення всіх замовлених піц
        public Order Build() {
            return order;
        }
    }
}