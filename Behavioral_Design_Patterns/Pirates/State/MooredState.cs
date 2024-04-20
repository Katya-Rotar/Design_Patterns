using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.State
{
    //пришвартований стан
    public class MooredState : IShipState
    {
        public void Attack()
        {
            Console.WriteLine("Unable to attack while docked.");
        }

        public void Move()
        {
            Console.WriteLine("Unable to move while docked.");
        }

        public void Repair()
        {
            Console.WriteLine("The ship is under repair during docking.");
        }

        public void UnloadCargo()
        {
            Console.WriteLine("Cargo can be unloaded during docking.");
        }
    }
}