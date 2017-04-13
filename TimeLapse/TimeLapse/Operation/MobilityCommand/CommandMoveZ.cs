using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveZ : Command
    {
        private int moveLength;
        public CommandMoveZ(int moveLength, string name = "Move Z")
        {
            this.CommandName = name;
            this.moveLength = moveLength;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.MoveC(moveLength);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveX>().Error(e.Message);
                return false;
            }
        }
    }
}
