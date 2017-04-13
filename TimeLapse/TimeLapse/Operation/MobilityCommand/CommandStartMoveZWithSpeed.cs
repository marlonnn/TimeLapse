using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandStartMoveZWithSpeed : Command
    {
        private int speed;
        public CommandStartMoveZWithSpeed (int speed, string name = "Start Move Z With Speed")
        {
            this.CommandName = name;
            this.speed = speed;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.MoveCWithSpeed(speed);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandStartMoveZWithSpeed>().Error(e.Message);
                return false;
            }
        }
    }
}
