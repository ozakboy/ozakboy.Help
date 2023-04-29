using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozakboy.Help
{
    public static class DatetimeToTimestampHelp
    {
        /// <summary>
        /// 將UTC DateTime轉換為Unix時間戳
        /// </summary>
        /// <param name="utcDateTime">要轉換的UTC DateTime</param>
        /// <returns>Unix時間戳</returns>
        public static long ToUnixTimestamp(this DateTime utcDateTime)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long unixTimestampInMilliseconds = (long)(utcDateTime - unixEpoch).TotalMilliseconds;
            return unixTimestampInMilliseconds;
        }
    }
}
