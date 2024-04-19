using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Command_Pattern
{
    // Піратський корабель
    public class PirateShip
    {
        public void Attack()
        {
            Console.WriteLine("Pirate ship attacks!");
        }
        public void ChangeCourse(string newCourse)
        {
            Console.WriteLine($"Pirate ship changes course to {newCourse}");
        }
    }
}
