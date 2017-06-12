using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.SystemDevice
{
    public class Slide
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 培养皿名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 培养皿包含胚胎的行数
        /// </summary>
        public int PlateRows { get; set; }

        /// <summary>
        /// 培养皿包含胚胎的列数
        /// </summary>
        public int PlateColumns { get; set; }

        /// <summary>
        /// 所有的胚胎细胞
        /// </summary>
        public List<Cell> Cells { get; set; }
    }
}
