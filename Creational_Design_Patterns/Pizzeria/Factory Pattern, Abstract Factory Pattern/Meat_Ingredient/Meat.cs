using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern
{
    public abstract class Meat : IIngredient
    {
        public abstract string Name { get; }
    }
}