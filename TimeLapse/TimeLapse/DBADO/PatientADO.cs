using Summer.System.Data;
using Summer.System.Data.DbMapping;

namespace TimeLapse.DBADO
{
    public class PatientADO : SmrAdoTmplate<TPatient>
    {
    }

    [TableAttribute("patient")]
    public class TPatient
    {
        /// <summary>
        /// 记录编号
        /// </summary>
        [FieldAttribute("patient_id", PrimaryKey = true)]
        public uint Patient_ID;

        /// <summary>
        /// 患者编号
        /// </summary>
        [FieldAttribute("patient_code")]
        public string Patient_code;

        /// <summary>
        /// 患者姓名
        /// </summary>
        [FieldAttribute("patient_name")]
        public string Patient_name;
    }
}
