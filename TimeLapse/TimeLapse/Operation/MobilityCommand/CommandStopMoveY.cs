using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandStopMoveY : Command
    {
        public CommandStopMoveY (string name = "Stop Move Y")
        {
            this.CommandName = name;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.StopMoveB();
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandStopMoveY>().Error(e.Message);
                return false;
            }
        }
    }
}
