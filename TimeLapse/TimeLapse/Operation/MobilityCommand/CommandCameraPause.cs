using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandCameraPause : Command
    {
        public CommandCameraPause(string name = "Pause Camera")
        {
            this.CommandName = name;
        }

        public override bool Execute()
        {
            return Camera.FreezeLive();
        }
    }
}
