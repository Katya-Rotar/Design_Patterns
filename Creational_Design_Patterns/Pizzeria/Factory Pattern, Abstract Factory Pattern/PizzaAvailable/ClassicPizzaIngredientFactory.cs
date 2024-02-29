using Pizzeria.Factory_Pattern.Cheese_Ingredient;
using Pizzeria.Factory_Pattern.Meat_Ingredient;
using Pizzeria.Factory_Pattern.Sauce_Ingredient;
using Pizzeria.Factory_Pattern.Vegetable_Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern
{
    public class ClassicPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public List<Cheese> CreateCheese()
        {
            List<Cheese> cheeses = new List<Cheese>();
            cheeses.Add(new Mozzarella());
            return cheeses;
        }

        public List<Meat> CreateMeat()
        {
            List<Meat> meats = new List<Meat>();
            meats.Add(new Ham());
            meats.Add(new Bacon());
            return meats;
        }

        public List<Sauce> CreateSauce()
        {
            List<Sauce> sauces = new List<Sauce>();
            sauces.Add(new TomatoSauce());
            return sauces;
        }

        public List<Vegetable> CreateVegetable()
        {
            List<Vegetable> vegetables = new List<Vegetable>();
            vegetables.Add(new Onion());
            vegetables.Add(new Paprika());
            return vegetables;
        }

        public string PrintPizzaIngredient()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("- Cheese:\n");
            foreach (var cheese in CreateCheese())
            {
                stringBuilder.Append($"  * {cheese.Name}\n");
            }

            stringBuilder.Append("- Meat:\n");
            foreach (var meat in CreateMeat())
            {
                stringBuilder.Append($"  * {meat.Name}\n");
            }

            stringBuilder.Append("- Sauce:\n");
            foreach (var sauce in CreateSauce())
            {
                stringBuilder.Append($"  * {sauce.Name}\n");
            }

            stringBuilder.Append("- Vegetable:\n");
            foreach (var vegetable in CreateVegetable())
            {
                stringBuilder.Append($"  * {vegetable.Name}\n");
            }

            return stringBuilder.ToString();
        }
    }
}