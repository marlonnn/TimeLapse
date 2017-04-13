
using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandStopMoveZ : Command
    {
        public CommandStopMoveZ (string name = "Stop Move Z")
        {
            this.CommandName = name;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.StopMoveC();
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandStopMoveZ>().Error(e.Message);
                return false;
            }
        }
    }
}
