using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria.Factory_Pattern__Abstract_Factory_Pattern.Interface
{
    public interface IPizzaFactory
    {
        Pizza CreatePizza(string type);
    }
}
