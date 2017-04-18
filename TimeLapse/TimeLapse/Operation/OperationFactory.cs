using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeLapse.Operation.MobilityCommand;

namespace TimeLapse.Operation
{
    public class OperationFactory
    {
        public CommandQueue CommandQueue { get; set; }

        public Dictionary<string, Command> CommandFactory { get; set; }

        public bool MobilityInitialized { get; set; }

        public void ExecuteInternal()
        {
            if (CommandQueue != null)
            {
                Command command = CommandQueue.Pop();
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
                    CommandCameraPosition commandTest = (CommandCameraPosition)CommandFactory["Camera Position"];
                    commandTest.Execute();
                }
            }
            catch (Exception)
            {
                LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command fail", "Camera Position"));
            }
        }

    }
}
