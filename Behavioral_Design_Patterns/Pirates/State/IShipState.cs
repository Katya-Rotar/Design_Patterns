using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.State
{
    public interface IShipState
    {
        void Move(); //переміщується
        void Attack(); //атака
        void Repair(); //ремонт
        void UnloadCargo(); //вивантаження вантажу
    }
}
