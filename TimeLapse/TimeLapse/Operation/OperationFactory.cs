using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeLapse.Operation.MobilityCommand;

namespace TimeLapse.Operation
{
    /// <summary>
    /// 操作工厂 （相机和运动控制平台）
    /// 1.开启计划任务，负责循环处理任务队列中的任务
    /// 2.若运动平台已经初始化，则循环获取运动平台坐标位置
    /// 3.高并发性 Spring.Scheduing.Quartz20 来调度执行
    /// </summary>
    /// <remarks>
    /// 公司：CII-TECH
    /// 作者：钟文               
    /// 创建日期：2017-4-19   
    /// </remarks>
    public class OperationFactory
    {
        //命令工厂
        public CommandFactory CommandFactory { get; set; }

        public bool MobilityInitialized { get; set; }

        public void ExecuteInternal()
        {
            if (CommandFactory.CommandQueue != null)
            {
                Command command = CommandFactory.CommandQueue.Pop();
                if (command != null)
                {
                    if (command.CommandName == "Move Start" || command.CommandName == "Move Exit")
                    {
                        MobilityInitialized = command.Execute();
                        LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command {1}",
                            command.CommandName, MobilityInitialized ? "success" : "fail"));
                    }
                    else
                    {
                        if (command.Execute())
                        {
                            LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command success", command.CommandName));
                        }
                        else
                        {
                            LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command fail", command.CommandName));
                        }
                    }
                }
            }
        }

        public void ExecuteMobilityInternal()
        {
            try
            {
                if (MobilityInitialized)
                {
                    CommandCameraPosition commandCameraPosition = CommandFactory.CreateCommand<CommandCameraPosition>("Camera Position");
                    commandCameraPosition.Execute();
                }
            }
            catch (Exception)
            {
                LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command fail", "Camera Position"));
            }
        }

    }
}
