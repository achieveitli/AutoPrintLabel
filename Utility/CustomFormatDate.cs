using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Utility
{
    public static class CustomFormatDate
    {
        private static DateTime GetDateTime(string date)
        {
            return Convert.ToDateTime(date);
        }
        /// <summary>
        /// 格式化为yyyMMdd
        /// </summary>
        /// <param name="date">日期字符串string</param>
        /// <returns>string</returns>
        public static string GetyyyyMMdd(string date)
        {
            string nDate = Convert.ToString(GetDateTime(date).ToString("yyyyMMdd"));
            return nDate;
        }
        /// <summary>
        /// 格式化为yymmdd
        /// </summary>
        /// <param name="date">日期字符串string</param>
        /// <returns></returns>
        public static string GetyyMMd(string date)
        {
            string nDate = Convert.ToString(GetDateTime(date).ToString("yyyyMMdd"));
            nDate = nDate.Substring(2);
            return nDate;
        }
        /// <summary>
        /// 格式化为yyyy-MM-dd
        /// </summary>
        /// <param name="date">日期字符串string</param>
        /// <returns>string</returns>
        public static string GetyyyyMMddHeng(string date)
        {
            string nDate = Convert.ToString(GetDateTime(date).ToString("yyyy-MM-dd"));
            return nDate;
        }

        /// <summary>
        /// 格式化为yyyy/MM/dd
        /// </summary>
        /// <param name="date">日期字符串string</param>
        /// <returns>string</returns>
        public static string GetyyyyMMddXie(string date)
        {
            string nDate = Convert.ToString(GetDateTime(date).ToString("yyyy/MM/dd"));
            return nDate;
        }
        /// <summary>
        /// 获取年周
        /// </summary>
        /// <param name="dateStr">日期字符串string</param>
        /// <returns></returns>
        public static string GetyyWeek(string dateStr)
        {
            DateTime date = Convert.ToDateTime(dateStr);
            return GetyyWeek(date);
            //GregorianCalendar gc = new GregorianCalendar();
            //int weekOfYear = gc.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            //return date.Year.ToString().Substring(2) + weekOfYear;
        }
        /// <summary>
        /// 获取年周
        /// </summary>
        /// <param name="dataTime">DateTime对象</param>
        /// <returns></returns>
        public static string GetyyWeek(DateTime dataTime)
        {
            GregorianCalendar gc = new GregorianCalendar();
            int weekOfYear = gc.GetWeekOfYear(dataTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            return dataTime.Year.ToString().Substring(2) + weekOfYear;
        }
    }
}
