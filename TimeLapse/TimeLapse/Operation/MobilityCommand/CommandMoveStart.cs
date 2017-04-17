using Summer.System.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation.MobilityCommand
{
    public class CommandMoveStart : Command
    {
        private string ipAddress;

        public string IpAddress
        {
            get { return this.ipAddress; }
            set { this.ipAddress = value; }
        }

        public CommandMoveStart(string ipAddress, string name = "Move Start")
        {
            this.CommandName = name;
            this.ipAddress = ipAddress;
        }

        public override bool Execute()
        {
            try
            {
                return MobilityController.Init(ipAddress);
            }
            catch (Exception e)
            {
                LogHelper.GetLogger<CommandMoveStart>().Error(e.Message);
                return false;
            }
        }
    }
}
