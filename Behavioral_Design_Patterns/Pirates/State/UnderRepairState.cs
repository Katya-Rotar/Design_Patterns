using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.State
{
    //У стані ремонту
    public class UnderRepairState : IShipState
    {
        public void Attack()
        {
            Console.WriteLine("Cannot attack while under repair.");
        }

        public void Move()
        {
            Console.WriteLine("Cannot move while under repair.");
        }

        public void Repair()
        {
            Console.WriteLine("Ship is already under repair.");
        }

        public void UnloadCargo()
        {
            Console.WriteLine("It is possible to unload cargo during repair.");
        }
    }
}