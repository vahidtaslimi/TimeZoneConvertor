using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TimeZoneConvertor.Ios
{
    public class tzSelectionCell : UITableViewCell
    {
        #region Static Fields

        public static readonly NSString Key = new NSString("tzSelectionCell");

        #endregion

        #region Fields

        private TimeZoneInfo timeZone;

        #endregion

        #region Constructors and Destructors

        public tzSelectionCell()
            : base(UITableViewCellStyle.Value1, Key)
        {

        }

        public TimeZoneInfo TimeZoneInfo
        {
            get { return this.timeZone; }
            set
            {
                this.timeZone = value;
                this.TextLabel.Text = string.Format("({0}) {1}-{2}", this.timeZone.BaseUtcOffset.ToString(), this.timeZone.DisplayName, this.timeZone.StandardName);
            }
        }
        #endregion
    }
}