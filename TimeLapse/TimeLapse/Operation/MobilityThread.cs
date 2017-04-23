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
    public class MobilityThread
    {
        //命令工厂
        public CommandFactory CommandFactory { get; set; }

        public bool ExecuteMobility { get; set; }

        public MobilityThread()
        {
            ExecuteMobility = false;
        }
        public void Start()
        {
            ExecuteMobility = true;
        }

        public void Stop()
        {
            ExecuteMobility = false;
        }

        public void ExecuteInternal()
        {
            while (true)
            {
                try
                {
                    if (MobilityUtil.MobilityInitialized)
                    {
                        CommandCameraPosition commandCameraPosition = CommandFactory.CreateCommand<CommandCameraPosition>("Camera Position");
                        commandCameraPosition.Execute();
                    }
                }
                catch (Exception)
                {
                    LogHelper.GetLogger<OperationFactory>().Debug(string.Format("Execute <{0}> command fail", "Camera Position"));
                }
                Thread.Sleep(1000);
            }
        }
    }
}
