using Summer.System.Data;
using Summer.System.Data.DbMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.DBADO
{
    public class TransferADO : SmrAdoTmplate<TTransfer>
    {
    }

    [TableAttribute("transfer")]
    public class TTransfer
    {
        /// <summary>
        /// 本地对象
        /// </summary>
        [FieldAttribute("transfer_local")]
        public string Transfer_Local;

        /// <summary>
        /// 连接状态
        /// </summary>
        [FieldAttribute("transfer_status")]
        public string Transfer_Status;

        /// <summary>
        /// 传输图片数
        /// </summary>
        [FieldAttribute("transfer_transfer_num")]
        public UInt16 Transfer_Transfer_Num;

        /// <summary>
        /// 传输时间
        /// </summary>
        [FieldAttribute("transfer_time")]
        public DateTime Transfer_Time;
    }
}
