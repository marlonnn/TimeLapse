using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandStopMove : Command
    {
        public CommandStopMove (string name = "Stop Move")
        {
            this.CommandName = name;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.StopMove();
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandStopMove>().Error(e.Message);
                return false;
            }
        }
    }
}
