using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TimeLapse.Operation.MobilityCommand;

namespace TimeLapse.Operation
{
    public class OperationThread
    {
        //命令工厂
        public CommandFactory CommandFactory { get; set; }

        public bool ExecuteRun { get; set; }

        //public bool MobilityInitialized { get; set; }

        public OperationThread()
        {
            ExecuteRun = false;
        }

        public void Start()
        {
            ExecuteRun = true;
        }

        public void Stop()
        {
            ExecuteRun = false;
        }

        public void ExecuteInternal()
        {
            while (ExecuteRun)
            {
                if (CommandFactory.CommandQueue != null)
                {
                    Command command = CommandFactory.CommandQueue.Pop();
                    if (command != null)
                    {
                        if (command.Execute())
                        {
                            LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command success", command.CommandName));
                        }
                        else
                        {
                            LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command fail", command.CommandName));
                        }
                        //if (command.CommandName == "Move Start" || command.CommandName == "Move Exit")
                        //{
                        //    MobilityInitialized = command.Execute();
                        //    LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command {1}",
                        //        command.CommandName, MobilityInitialized ? "success" : "fail"));
                        //}
                        //else
                        //{
                        //    if (command.Execute())
                        //    {
                        //        LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command success", command.CommandName));
                        //    }
                        //    else
                        //    {
                        //        LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command fail", command.CommandName));
                        //    }
                        //}
                    }
                }
                Thread.Sleep(100);
            }
        }
    }
}
