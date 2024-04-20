using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Visitor
{
    // Абстрактний клас елементу інвентаря
    public abstract class InventoryItem
    {
        // Метод прийняття відвідувача
        public abstract void Accept(IInventoryVisitor visitor);
    }
}