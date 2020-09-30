using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wochenbericht
{
 public static class DateTimeExtension
    {

        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
        public static DateTime EndOfWeek(this DateTime endDt, DayOfWeek endOfWeek)
        {
            int diff = (0 + (endDt.DayOfWeek - endOfWeek)) % 7;
            return endDt.AddDays(-1 * diff).Date;
        }
    }
}
