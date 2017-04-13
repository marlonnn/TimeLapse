using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandStopMoveX : Command
    {
        public CommandStopMoveX (string name = "Stop Move X")
        {
            this.CommandName = name;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.StopMoveA();
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandStopMoveX>().Error(e.Message);
                return false;
            }
        }
    }
}
