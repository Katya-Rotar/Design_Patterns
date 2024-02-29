using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.Interface;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.PizzaAvailable;
using System.Xml.Linq;

namespace Pizzeria.Factory_Pattern
{
    public class PizzaFactory : IPizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "Pepperoni Pizza":
                    return new PepperoniPizza(new PepperoniPizzaIngredientFactory());
                case "Classic Pizza":
                    return new ClassicPizza(new ClassicPizzaIngredientFactory());
                case "Capricciosa Pizza":
                    return new CapricciosaPizza(new CapricciosaPizzaIngredientFactory());
                default:
                    Console.WriteLine($"Unknown pizza type: {type}");
                    return null;
            }
        }
    }
}