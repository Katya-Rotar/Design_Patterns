using Pizzeria.Factory_Pattern;
using Pizzeria.Factory_Pattern.Meat_Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.PizzaAvailable
{
    public class CapricciosaPizza : Pizza
    {
        public CapricciosaPizza (IPizzaIngredientFactory factory) : base(factory)
        {
        }

        public override string GetName()
        {
            return "Capricciosa Pizza";
        }

        public override string PrintPizza()
        {
            CapricciosaPizzaIngredientFactory capricciosa = new CapricciosaPizzaIngredientFactory();
            return $"{GetName()}:\n {capricciosa.PrintPizzaIngredient()}";
        }

        // Новий метод для отримання назви піци для Builder Pattern
        public static string GetPizzaName()
        {
            return new CapricciosaPizza(null).GetName();
        }

        //Prototype Pattern
        public override ICloneable Clone()
        {
            CapricciosaPizza clone = new CapricciosaPizza(this.ingredientFactory);
            return clone;
        }
    }
}