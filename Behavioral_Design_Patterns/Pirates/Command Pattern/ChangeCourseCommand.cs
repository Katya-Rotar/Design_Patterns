using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Command_Pattern
{
    // Реалізація команди: зміна курсу корабля
    public class ChangeCourseCommand : ICommand
    {
        private PirateShip pirateShip;
        private string newCourse;

        public ChangeCourseCommand(PirateShip pirateShip, string newCourse)
        {
            this.pirateShip = pirateShip;
            this.newCourse = newCourse;
        }

        public void Execute()
        {
            pirateShip.ChangeCourse(newCourse);
        }
    }
}
