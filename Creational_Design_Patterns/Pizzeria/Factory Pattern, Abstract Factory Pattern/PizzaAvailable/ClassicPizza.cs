using Pizzeria.Factory_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.PizzaAvailable
{
    public class ClassicPizza : Pizza
    {
        public ClassicPizza(IPizzaIngredientFactory factory) : base(factory)
        {
        }

        public override string GetName()
        {
            return "Classic Pizza";
        }

        public override string PrintPizza()
        {
            ClassicPizzaIngredientFactory classic = new ClassicPizzaIngredientFactory();
            return $"{GetName()}:\n {classic.PrintPizzaIngredient()}";
        }

        // Новий метод для отримання назви піци для Builder Pattern
        public static string GetPizzaName()
        {
            return new ClassicPizza(null).GetName();
        }

        //Prototype Pattern
        public override ICloneable Clone()
        {
            ClassicPizza clone = new ClassicPizza(this.ingredientFactory);
            return clone;
        }
    }
}