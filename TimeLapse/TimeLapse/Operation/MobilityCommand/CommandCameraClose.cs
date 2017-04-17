using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandCameraClose : Command
    {
        public CommandCameraClose(string name = "Close Camera")
        {
            this.CommandName = name;
        }

        public override bool Execute()
        {
            return Camera.ExitCamera();
        }
    }
}
