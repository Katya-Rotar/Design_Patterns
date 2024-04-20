using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.TemplateMethod
{
    //Бриґ
    public class BrigBuilder : ShipBuilder
    {
        public override void Decker()
        {
            //Два рівні, верхній для екіпажу та зброї, нижній для вантажу та екіпажу.
            Console.WriteLine("Two levels, upper for crew and weapons, lower for cargo and crew.");
        }

        public override void Interior()
        {
            //Каюти, сховища.
            Console.WriteLine("Cabins, storage.");
        }

        public override void ManeuveringEquipment()
        {
            //Керування, лебідки.
            Console.WriteLine("Steering, winches.");
        }

        public override void Sails()
        {
            //Дві мачти, кілька вітрил.
            Console.WriteLine("Two masts, multiple sails.");
        }

        public override void Weapons()
        {
            //Гармати, мушкети, пістолети.
            Console.WriteLine("Cannons, muskets, pistols.");
        }
    }
}