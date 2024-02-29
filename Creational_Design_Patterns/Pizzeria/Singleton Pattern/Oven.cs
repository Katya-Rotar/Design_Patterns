using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    //Singleton Pattern
    public class Oven
    {
        private static Oven oven = null;

        private Oven() { }
        public static Oven getInstance() {
            if( oven == null )
            {
                oven = new Oven();
            }
            return oven;
        }
    }
}
