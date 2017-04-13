using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandStartMoveXWithSpeed : Command
    {
        private int speed;
        public CommandStartMoveXWithSpeed (int speed, string name = "Start Move X With Speed")
        {
            this.CommandName = name;
            this.speed = speed;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.MoveAWithSpeed(speed);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandStartMoveXWithSpeed>().Error(e.Message);
                return false;
            }
        }
    }
}
