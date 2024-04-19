using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Command_Pattern
{
    // Реалізація команди: напад на торговий корабель
    public class AttackCommand : ICommand
    {
        private PirateShip pirateShip;
        public AttackCommand(PirateShip pirateShip) { 
            this.pirateShip = pirateShip;
        }

        public void Execute()
        {
            pirateShip.Attack();
        }
    }
}
