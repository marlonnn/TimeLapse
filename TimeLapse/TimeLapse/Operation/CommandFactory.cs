using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation
{
    public class CommandFactory
    {
        public CommandQueue CommandQueue { get; set; }

        public void ExecuteInternal()
        {
            if (CommandQueue != null)
            {
                Command command = CommandQueue.Pop();
                if (command != null && !command.Execute())
                {
                    LogHelper.GetLogger<CommandFactory>().Error(string.Format("{0} command error", command.CommandName));
                }
            }
        }

    }
}
