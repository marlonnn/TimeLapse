using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandCameraStart : Command
    {
        public CommandCameraStart(string name = "Start Camera")
        {
            this.CommandName = name;
        }

        public override bool Execute()
        {
            return Camera.Init();
        }
    }
}
