using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation
{
    /// <summary>
    /// 抽象命令，所有命令必须继承自抽象命令，实现该抽象方法
    /// 包含相机和运动平台控制器
    /// <remarks>
    /// 公司：CII-TECH
    /// 作者：钟文               
    /// 创建日期：2017-4-10   
    /// </remarks>
    /// </summary>
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
