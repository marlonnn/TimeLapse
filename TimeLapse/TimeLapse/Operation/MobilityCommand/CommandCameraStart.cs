using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandCameraStart : Command
    {
        public IntPtr IntPtr { get; set; }
        public CommandCameraStart(string name = "Start Camera")
        {
            this.CommandName = name;
        }

        public override bool Execute()
        {
            if (Camera.Init())
            {
                return Camera.DisplayLive(IntPtr);
            }
            else
            {
                return false;
            }
        }
    }
}
