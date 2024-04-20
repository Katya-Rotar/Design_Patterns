using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.State
{
    public class BattleState : IShipState
    {
        public void Move()
        {
            Console.WriteLine("Ship is moving tactically.");
        }

        public void Attack()
        {
            Console.WriteLine("Ship is attacking enemy vessels.");
        }

        public void Repair()
        {
            Console.WriteLine("Cannot repair during battle.");
        }

        public void UnloadCargo()
        {
            Console.WriteLine("Cannot unload cargo during battle.");
        }
    }
}