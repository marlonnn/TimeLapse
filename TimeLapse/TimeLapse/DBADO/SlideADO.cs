using Summer.System.Data;
using Summer.System.Data.DbMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.DBADO
{
    public class SlideADO : SmrAdoTmplate<TSlide>
    {
    }

    [TableAttribute("slide")]
    public class TSlide
    {
        /// <summary>
        /// 培养皿id
        /// </summary>
        [FieldAttribute("slide_id", PrimaryKey = true)]
        public uint Slide_ID;

        /// <summary>
        /// 培养皿编号
        /// </summary>
        [FieldAttribute("slide_code")]
        public string Slide_code;

        /// <summary>
        /// 培养皿描述
        /// </summary>
        [FieldAttribute("slide_description")]
        public string Slide_description;

        /// <summary>
        /// 受精时间
        /// </summary>
        [FieldAttribute("slide_fertilization")]
        public DateTime Slide_fertilization;

        /// <summary>
        /// 治疗id
        /// </summary>
        [FieldAttribute("slide_treatment_id")]
        public uint Slide_treatment_id;
    }
}
