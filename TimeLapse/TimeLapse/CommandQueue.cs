using Summer.System.Collections.Concurrent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.Operation
{
    /// <summary>
    /// 执行任务的队列
    /// </summary>
    public class CommandQueue : ConcurrentQueue<Command>
    {
    }
}
