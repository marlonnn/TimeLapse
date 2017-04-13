using Summer.System.Log;
using System;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveAbsolute : Command
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;
        public bool OnlyMoveXY { private set; get; }

        public CommandMoveAbsolute(int x, int y, string commandName = "Move Absolute")
        {
            this.CommandName = commandName;
            this.x = x;
            this.y = y;
            OnlyMoveXY = true;
        }

        public CommandMoveAbsolute(int x, int y, int z, string commandName = "Move Absolute")
        {
            this.CommandName = commandName;
            this.x = x;
            this.y = y;
            this.z = z;
            OnlyMoveXY = false;
        }

        public override bool Execute()
        {
            try
            {
                if (OnlyMoveXY)
                {
                    return MobilityController.MoveAbsolute(x, y);
                }
                else
                {
                    return MobilityController.MoveAbsolute(x, y, z);
                }
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveAbsolute>().Error(e.Message);
                return false;
            }

        }
    }
}
