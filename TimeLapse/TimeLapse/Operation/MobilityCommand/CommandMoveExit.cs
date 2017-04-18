using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveExit : Command
    {
        public UI.ControlForm.UpdateMotionCtrls UpdateMotionCtrlsHandler { get; set; }

        public CommandMoveExit (string name = "Move Exit")
        {
            this.CommandName = name;
        }

        public override bool Execute()
        {
            try
            {
                bool success = MobilityController.CloseGCLib();
                if (UpdateMotionCtrlsHandler != null && !success)
                {
                    UpdateMotionCtrlsHandler(success);
                }
                return success;
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveStart>().Error(e.Message);
                return false;
            }
        }
    }
}
