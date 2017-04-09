using Summer.System.Data;
using Summer.System.Data.DbMapping;

namespace TimeLapse.DBADO
{
    public class TreamentADO : SmrAdoTmplate<TTreament>
    {
    }

    [TableAttribute("treatment")]
    public class TTreament
    {
        /// <summary>
        /// 治疗id
        /// </summary>
        [FieldAttribute("treatment_id", PrimaryKey = true)]
        public uint Treatment_ID;

        /// <summary>
        /// 治疗名称
        /// </summary>
        [FieldAttribute("treatment_name")]
        public string Treatment_Name;

        /// <summary>
        /// 患者id
        /// </summary>
        [FieldAttribute("treatment_partient_id")]
        public uint Treatment_Patient_ID;
    }
}
