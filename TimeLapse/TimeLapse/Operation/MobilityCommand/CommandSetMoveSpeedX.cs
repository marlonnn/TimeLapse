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
    public class CommandSetMoveSpeedX : Command
    {
        private int speed;

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public CommandSetMoveSpeedX (int speed, string name = "Set Move Speed X")
        {
            this.CommandName = name;
            this.speed = speed;
        }

        public override bool Execute()
        {
            try
            {
                return MobilityController.SetSpeedA(speed);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandSetMoveSpeedX>().Error(e.Message);
                return false;
            }
        }
    }
}
