using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.TemplateMethod
{
    //Фрегат
    public class FrigateBuilder : ShipBuilder
    {
        public override void Decker()
        {
            //Кілька рівнів, верхня для екіпажу та зброї, нижня для вантажу та екіпажу.
            Console.WriteLine("Multiple levels, upper for crew and weapons, lower for cargo and crew.");
        }

        public override void Interior()
        {
            //Розкішні каюти, сховища.
            Console.WriteLine("Lavish cabins, storage.");
        }

        public override void ManeuveringEquipment()
        {
            //Продумане керування, лебідки.
            Console.WriteLine("Advanced steering, winches.");
        }

        public override void Sails()
        {
            //Кілька мачт, численні вітрила.
            Console.WriteLine("Multiple masts, numerous sails.");
        }

        public override void Weapons()
        {
            //Добре озброєні, гармати, мушкети.
            Console.WriteLine("Well-armed, cannons, muskets.");
        }
    }
}