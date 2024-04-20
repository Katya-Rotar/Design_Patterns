using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Visitor
{
    // Інтерфейс відвідувача для обробки різних елементів інвентаря
    public interface IInventoryVisitor
    {
        void VisitWeapon(Weapon weapon); //зброя
        void VisitFood(Food food); //їжа
        void VisitDrink(Drink drink); //напої
        void VisitTreasure(Treasure treasure); //скарб
    }
}