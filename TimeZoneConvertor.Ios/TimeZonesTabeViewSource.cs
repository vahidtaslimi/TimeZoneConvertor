using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeZoneConvertor.Ios
{
    using System.Collections.ObjectModel;

    using MonoTouch.Foundation;
    using MonoTouch.UIKit;

    public class TimeZonesTabeViewSource : UITableViewSource
    {
        #region Fields

        #endregion

        #region Constructors and Destructors

        public TimeZonesTabeViewSource()
        {
        }

        #endregion

        #region Public Methods and Operators

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(tzSelectionCell.Key) as TimeZonesTabeViewCell;

            if (cell == null)
            {
                cell = new TimeZonesTabeViewCell();
            }

            return cell;
        }

        public override int NumberOfSections(UITableView tableView)
        {
            // TODO: return the actual number of sections
            return 1;
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            return 7;
        }

        /*   public override string TitleForFooter(UITableView tableView, int section)
           {
               return "Footer";
           }

        public override string TitleForHeader(UITableView tableView, int section)
        {
            return "Header " + section.ToString();
        }
          */
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {

        }
        #endregion
    }
}

