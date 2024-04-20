using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.TemplateMethod
{
    //Галеон
    public class GalleonBuilder : ShipBuilder
    {
        public override void Decker()
        {
            //Простора верхня палуба, нижні палуби.
            Console.WriteLine("Spacious upper deck, lower decks.");
        }

        public override void Interior()
        {
            //Розкішні каюти, сховища.
            Console.WriteLine("Luxurious cabins, storage.");
        }

        public override void ManeuveringEquipment()
        {
            //Міцне керування, лебідки.
            Console.WriteLine("Strong steering, winches.");
        }

        public override void Sails()
        {
            //Кілька мачт, великі вітрила.
            Console.WriteLine("Multiple masts, large sails.");
        }

        public override void Weapons()
        {
            //Важкі гармати, мушкети.
            Console.WriteLine("Heavy cannons, muskets.");
        }
    }
}