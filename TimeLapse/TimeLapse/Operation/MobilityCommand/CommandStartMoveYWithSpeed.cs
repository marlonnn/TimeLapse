using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandStartMoveYWithSpeed : Command
    {
        private int speed;
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public CommandStartMoveYWithSpeed (int speed, string name = "Start Move Y With Speed")
        {
            this.CommandName = name;
            this.speed = speed;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.MoveBWithSpeed(speed);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandStartMoveYWithSpeed>().Error(e.Message);
                return false;
            }
        }
    }
}
