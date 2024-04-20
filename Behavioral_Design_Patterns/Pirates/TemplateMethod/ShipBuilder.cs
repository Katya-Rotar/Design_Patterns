using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.TemplateMethod
{
    // Базовий клас для будови корабля
    public abstract class ShipBuilder
    {
        public abstract void Sails(); // Вітрила
        public abstract void Decker(); // Палуба
        public abstract void Weapons(); // Зброя
        public abstract void Interior(); // Внутрішні приміщення
        public abstract void ManeuveringEquipment(); // Обладнання для маневрування

        public void BuildShip()
        {
            Sails();
            Decker();
            Weapons();
            Interior();
            ManeuveringEquipment();
        }
    }
}