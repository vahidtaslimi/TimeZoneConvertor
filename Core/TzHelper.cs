namespace TimeZoneConvertor.Core
{
    using System;
    using System.Collections.Generic;

    public class TzHelper
    {
        #region Public Methods and Operators

        public DateTime Conver(DateTime date, string timeZoneInfoId)
        {
            var selectedDate = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(date, timeZoneInfoId);
            return selectedDate;
        }

        public IReadOnlyCollection<TimeZoneInfo> FillTimeZones()
        {
            var tzs = TimeZoneInfo.GetSystemTimeZones();
            return tzs;
        }

        public List<Tz> GetTimes(DateTime selectedDate, string timezoneId)
        {
            var result = new List<Tz>();
            for (int i = 0; i < 24; i++)
            {
                var date = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, i, 0, 0);
                var tz = new Tz();
                tz.BaseDateTime = date;
                tz.DateTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(date, timezoneId);
                tz.TimeZoneId = timezoneId;
                if (tz.DateTime.Day > date.Day)
                {
                    tz.IsPlusOneDay = true;
                }

                if (tz.DateTime.Day < date.Day)
                {
                    tz.IsMinusOneDay = true;
                }

                result.Add(tz);
                i++;
            }

            return result;
        }

        #endregion
    }
}