using Summer.System.Log;
using System;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveAbsolute : Command
    {
        private int x = 0;
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        private int y = 0;
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        private int z = 0;
        public int Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
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
