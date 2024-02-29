using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern
{
    public interface IPizzaIngredientFactory
    {
        List<Cheese> CreateCheese();
        List<Meat> CreateMeat();
        List<Sauce> CreateSauce();
        List<Vegetable> CreateVegetable();

        string PrintPizzaIngredient();
    }
}