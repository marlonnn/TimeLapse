using Summer.System.Log;
using System;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveHome : Command
    {
        public CommandMoveHome(string name = "Move Home")
        {
            this.CommandName = name;
        }
        public override bool Execute()
        {
            try
            {
                return MobilityController.GoHome();
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveAbsolute>().Error(e.Message);
                return false;
            }
        }
    }
}
