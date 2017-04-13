using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveExit : Command
    {
        public CommandMoveExit (string name = "Move Exit")
        {
            this.CommandName = name;
        }

        public override bool Execute()
        {
            return MobilityController.CloseGCLib();
        }
    }
}
