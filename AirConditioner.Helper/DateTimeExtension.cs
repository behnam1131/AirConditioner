using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AirConditioner.Helper
{
    public static class DateTimeExtension
    {
        public static string ConvertToPersianDate(this DateTime input)
        {
            var persianCalendar = new PersianCalendar();

            var persianDate = persianCalendar.GetYear(input).ToString("0000") + "/" +
                              persianCalendar.GetMonth(input).ToString("00") + "/" +
                              persianCalendar.GetDayOfMonth(input).ToString("00");

            return persianDate;
        }

        public static DateTime ConvertToDateTime(this string input)
        {
            var dateTime = Regex.Split(input, "-");
            string[] date = Regex.Split(dateTime[0], "/");
            string[] time = Regex.Split(dateTime[0], ":");

            int year = Convert.ToInt32(date[0]);
            int month = Convert.ToInt32(date[1]);
            int day = Convert.ToInt32(date[2]);

            var pCalendar = new PersianCalendar();
            DateTime gDate = pCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);

            return gDate;

        }
    }
}
