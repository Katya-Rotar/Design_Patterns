using Pizzeria.Factory_Pattern;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern__Abstract_Factory_Pattern
{
    public abstract class Pizza : ICloneable
    {

        public IPizzaIngredientFactory ingredientFactory;

        public Pizza(IPizzaIngredientFactory factory)
        {
            ingredientFactory = factory;
        }

        public abstract string GetName();
        public abstract string PrintPizza();

        //Prototype Pattern
        public abstract object Clone();
    }
}
