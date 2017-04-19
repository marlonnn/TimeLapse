using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandCameraCapture : Command
    {
        public string PicturePath { get; set; }

        public string PictureName { get; set; }
        public CommandCameraCapture(string name = "Camera Capture")
        {
            this.CommandName = name;
        }

        public override bool Execute()
        {
            try
            {
                return Camera.SaveImage(PicturePath, PictureName);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveStart>().Error(e.Message);
                return false;
            }
        }
    }
}
