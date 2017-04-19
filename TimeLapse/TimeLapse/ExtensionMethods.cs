using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// convert local time to China Standard Time
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime ToCSTTime(this DateTime dateTime)
        {
            try
            {
                return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, "China Standard Time");
            }
            catch
            {
                return dateTime;
            }
        }
    }
}
