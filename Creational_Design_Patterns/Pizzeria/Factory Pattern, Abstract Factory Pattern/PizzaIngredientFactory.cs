using Pizzeria.Factory_Pattern;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.PizzaAvailable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern__Abstract_Factory_Pattern
{
    public class PizzaIngredientFactory
    {
        public IPizzaIngredientFactory getPizzaFactory(string name)
        {
            switch (name)
            {
                case "Pepperoni Pizza":
                    return new PepperoniPizzaIngredientFactory();
                case "Classic Pizza":
                    return new ClassicPizzaIngredientFactory();
                case "Capricciosa Pizza":
                    return new CapricciosaPizzaIngredientFactory();
                default:
                    Console.WriteLine($"Unknown pizza type: {name}");
                    return null;
            }
        }
    }
}