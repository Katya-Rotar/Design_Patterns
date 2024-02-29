using Pizzeria.Factory_Pattern;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.Interface;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.PizzaAvailable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern__Abstract_Factory_Pattern
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IPizzaIngredientFactory factory) : base(factory)
        {
        }

        public override string GetName()
        {
            return "Pepperoni Pizza";
        }

        public override string PrintPizza()
        {
            PepperoniPizzaIngredientFactory pepperoni = new PepperoniPizzaIngredientFactory();
            return $"{GetName()}:\n {pepperoni.PrintPizzaIngredient()}";
        }

        // Новий метод для отримання назви піци для Builder Pattern
        public static string GetPizzaName()
        {
            return new PepperoniPizza(null).GetName();
        }

        //Prototype Pattern
        public override ICloneable Clone()
        {
            PepperoniPizza clone = new PepperoniPizza(this.ingredientFactory);
            return clone;
        }
    }
}
