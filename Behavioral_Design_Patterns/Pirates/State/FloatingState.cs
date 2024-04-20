using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.State
{
    public class FloatingState : IShipState //плавуючий стан
    {
        public void Attack()
        {
            Console.WriteLine("Does not attack.");
        }

        public void Move()
        {
            Console.WriteLine("The ship floats in the waters.");
        }

        public void Repair()
        {
            Console.WriteLine("The ship is not under repair.");
        }

        public void UnloadCargo()
        {
            Console.WriteLine("Unable to unload cargo while sailing.");
        }
    }
}