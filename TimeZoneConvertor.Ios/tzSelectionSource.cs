using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TimeZoneConvertor.Ios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class tzSelectionSource : UITableViewSource
    {
        #region Fields

        private List<TimeZoneInfo> timeZones = null;
        private tzSelectionController parentController;

        private List<TimeZoneInfo> searchResult = null;

        #endregion

        #region Constructors and Destructors

        public tzSelectionSource(tzSelectionController parentController)
        {
            this.timeZones = TimeZoneInfo.GetSystemTimeZones().OrderBy(t => t.BaseUtcOffset.TotalMinutes).ThenBy(t => t.DisplayName).ToList();
            this.parentController = parentController;
        }

        #endregion

        #region Public Methods and Operators

        public void SearchAndFilter(string term)
        {
            if (string.IsNullOrWhiteSpace(term))
            {
                this.searchResult = null;
                return;
            }

            term = term.ToLower();
            this.searchResult = this.timeZones.Where(t => t.DisplayName.ToLower().Contains(term) || t.Id.ToLower().Contains(term)).ToList();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(tzSelectionCell.Key) as tzSelectionCell;

            if (cell == null)
            {
                cell = new tzSelectionCell();
            }

            if (this.searchResult != null)
            {
                cell.TimeZoneInfo = this.searchResult[indexPath.Row];
            }
            else
            {
                cell.TimeZoneInfo = this.timeZones[indexPath.Row];
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
            if (this.searchResult == null)
            {
                return this.timeZones.Count;
            }
            else
            {
                return this.searchResult.Count;
            }
        }

        /*   public override string TitleForFooter(UITableView tableView, int section)
           {
               return "Footer";
           }

           public override string TitleForHeader(UITableView tableView, int section)
           {
               return "Header";
           }
   */
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            TimeZoneInfo selected = null;
            if (this.searchResult != null)
            {
                selected = this.searchResult[indexPath.Row];
            }
            else
            {
                selected = this.timeZones[indexPath.Row];
            }

            this.parentController.ParentController.SetSelectedTimeZoneInfo(selected);
            this.parentController.NavigationController.PopToRootViewController(true);
        }
        #endregion
    }
}