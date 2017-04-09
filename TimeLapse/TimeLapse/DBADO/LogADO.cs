using Summer.System.Data;
using Summer.System.Data.DbMapping;
using System;

namespace TimeLapse.DBADO
{
    public class LogADO : SmrAdoTmplate<TLog>
    {
    }

    [TableAttribute("log")]
    public class TLog
    {
        /// <summary>
        /// 日志时间
        /// </summary>
        [FieldAttribute("log_date")]
        public DateTime Log_Date;

        /// <summary>
        /// 日志线程
        /// </summary>
        [FieldAttribute("log_thread")]
        public string Log_Thread;

        /// <summary>
        /// 日志等级
        /// </summary>
        [FieldAttribute("log_level")]
        public string Log_Level;

        /// <summary>
        /// 日志记录器
        /// </summary>
        [FieldAttribute("log_logger")]
        public string Log_Logger;

        /// <summary>
        /// 日志信息
        /// </summary>
        [FieldAttribute("log_message")]
        public string Log_Message;

        /// <summary>
        /// 日志异常
        /// </summary>
        [FieldAttribute("log_exception")]
        public string Log_Exception;
    }
}
