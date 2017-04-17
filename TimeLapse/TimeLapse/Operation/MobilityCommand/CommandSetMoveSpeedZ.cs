using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    /// <summary>
    /// 设置控制系统移动速度
    /// </summary>
    public class CommandSetMoveSpeedZ : Command
    {
        private int speed;
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public CommandSetMoveSpeedZ (int speed, string name = "Set Move Speed Z")
        {
            this.CommandName = name;
            this.speed = speed;
        }

        public override bool Execute()
        {
            try
            {
                return MobilityController.SetSpeedC(speed);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandSetMoveSpeedZ>().Error(e.Message);
                return false;
            }
        }
    }
}
