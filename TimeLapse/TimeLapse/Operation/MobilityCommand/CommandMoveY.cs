using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveY : Command
    {
        private int moveLength;
        public int MoveLength
        {
            get { return this.moveLength; }
            set { this.moveLength = value; }
        }
        public CommandMoveY(int moveLength, string name = "Move Y")
        {
            this.CommandName = name;
            this.moveLength = moveLength;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.MoveB(moveLength);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveX>().Error(e.Message);
                return false;
            }
        }
    }
}
