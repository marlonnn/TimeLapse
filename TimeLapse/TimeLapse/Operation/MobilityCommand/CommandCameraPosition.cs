using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandCameraPosition : Command
    {
        public float X { get; set; }
        public float XError { get; set; }

        public float Y { get; set; }
        public float YError { get; set; }
        public float Z { get; set; }
        public float ZError { get; set; }

        //委托事件 更新界面坐标轴和偏差 
        public UI.ControlForm.UpdateMotionPosition UpdateMotionPositionHandler;
        public CommandCameraPosition(string name = "Camera Position")
        {
            this.CommandName = name;
        }
        public override bool Execute()
        {
            try
            {
                X = MobilityController.GetPositionA();
                XError = MobilityController.GetErrorPositionA();

                Y = MobilityController.GetPositionB();
                YError = MobilityController.GetErrorPositionB();

                Z = MobilityController.GetPositionC();
                ZError = MobilityController.GetErrorPositionC();

                if (UpdateMotionPositionHandler != null)
                {
                    UpdateMotionPositionHandler(X, XError, Y, YError, Z, ZError);
                }
                return true;
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<OperationFactory>().Error(string.Format("Execute <{0}> command fail: \n Exception: {1}", 
                    CommandName, e.Message));
                return false;
            }
        }
    }
}
