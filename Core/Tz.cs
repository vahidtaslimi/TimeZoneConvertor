namespace TimeZoneConvertor.Core
{
    using System;

    public class Tz
    {
        #region Public Properties

        public DateTime BaseDateTime { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsMinusOneDay { get; set; }

        public bool IsPlusOneDay { get; set; }

        public string TimeZoneId { get; set; }

        #endregion
    }
}