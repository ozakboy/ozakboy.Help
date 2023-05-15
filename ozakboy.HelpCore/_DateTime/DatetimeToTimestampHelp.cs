using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ozakboy.HelpCore
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

        /// <summary>
        /// 將Unix時間戳轉換為UTC DateTime
        /// </summary>
        /// <param name="unixTimestamp">要轉換的Unix時間戳</param>
        /// <returns>對應的UTC DateTime</returns>
        public static DateTime FromUnixTimestamp(long unixTimestamp)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return unixEpoch.AddMilliseconds(unixTimestamp);
        }

        /// <summary>
        /// 取得預設時間 2000/1/1 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime DefulteData(this DateTime date)
        {
            return  new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        }
    }
}
