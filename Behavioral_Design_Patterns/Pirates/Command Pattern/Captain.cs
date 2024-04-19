using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Design_Patterns.Pirates.Command_Pattern
{
    //Капітан
    public class Captain
    {
        private ICommand? _command;

        //встановлення потрібної команди
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command?.Execute();
        }
    }
}
