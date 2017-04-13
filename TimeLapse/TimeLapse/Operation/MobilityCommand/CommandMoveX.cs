using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveX : Command
    {
        private int moveLength;
        public CommandMoveX(int moveLength, string name = "Move X")
        {
            this.CommandName = name;
            this.moveLength = moveLength;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.MoveA(moveLength);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveX>().Error(e.Message);
                return false;
            }
        }
    }
}
