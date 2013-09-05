using System;

namespace TimeZoneConvertor.Ios
{
    using System.Drawing;

    using MonoTouch.Foundation;
    using MonoTouch.UIKit;

    public class TimeZonesTabeViewCell : UITableViewCell
    {
        #region Static Fields

        public static readonly NSString Key = new NSString("TimeZonesTabeViewCell");

        #endregion

        #region Fields

        private TimeZoneInfo timeZone;

        #endregion

        #region Constructors and Destructors

        public TimeZonesTabeViewCell()
            : base(UITableViewCellStyle.Value1, Key)
        {
            this.AddDays();
        }

        #endregion

        #region Public Methods and Operators

        public void AddDays()
        {
            UILabel label = null;
            int x = 0;
            for (int i = 0; i < 20; i++)
            {
                label = new UILabel();
                label.Text = i.ToString();
                label.Frame = new RectangleF(x, 0, 40, 40);
                x += 50;
                this.ContentView.AddSubview(label);
            }
        }

        #endregion
    }
}