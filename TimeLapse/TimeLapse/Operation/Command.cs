using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation
{
    public abstract class Command
    {
        protected bool isExecuteComplete = false;
        public virtual bool IsExecuteComplete
        {
            get { return this.isExecuteComplete; }
            set { this.isExecuteComplete = value; }
        }
        public string CommandName { get; set; }

        protected MobilityController MobilityController { get; set; }

        protected Camera Camera { get; set; }

        public abstract bool Execute();
    }
}
