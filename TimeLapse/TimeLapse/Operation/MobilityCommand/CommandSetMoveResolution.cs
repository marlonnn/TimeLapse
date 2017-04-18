using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    /// <summary>
    /// 设置移动分辨率(倍数)，所有移动系统距离将是给定数值*移动分辨率*相机固定最小里程计
    /// </summary>
    public class CommandSetMoveResolution : Command
    {
        private int resolution;
        public int Resolution
        {
            get { return this.resolution; }
            set { this.resolution = value; }
        }
        public CommandSetMoveResolution (int resolution, string name = "Set Move Resolution")
        {
            this.resolution = resolution > 0 ? resolution : 1;
        }

        public override bool Execute()
        {
            try
            {
                return MobilityController.SetResolution(resolution);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandSetMoveResolution>().Error(e.Message);
                return false;
            }
        }
    }
}
