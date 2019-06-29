using System;
using System.Globalization;
using System.Text.RegularExpressions;

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
            string[] time = Regex.Split(input, "/");

            int year = Convert.ToInt32(time[0]);
            int month = Convert.ToInt32(time[1]);
            int day = Convert.ToInt32(time[2]);

            var pCalendar = new PersianCalendar();
            DateTime gDate = pCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);

            return gDate;

        }
    }
}