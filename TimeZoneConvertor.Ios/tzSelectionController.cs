using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TimeZoneConvertor.Ios
{
    [Register("tzSelectionController")]
    public partial class tzSelectionController : UITableViewController
    {
        private tzSelectionSource dataSource;

        public tzSelectionController()
            : base(UITableViewStyle.Grouped)
        {
        }

        public tzSelectionController(IntPtr handle)
            : base(handle)
        {
            //this.Title = NSBundle.MainBundle.LocalizedString ("Second", "Second");
            //this.TabBarItem.Image = UIImage.FromBundle ("second");
        }

        public FirstViewController ParentController
        {
            get;
            set;
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Register the TableView's data source
            dataSource = new tzSelectionSource(this);
            TableView.Source = dataSource;
            this.searchBar.TextChanged += searchBar_TextChanged;
        }

        private void searchBar_TextChanged(object sender, UISearchBarTextChangedEventArgs e)
        {
            dataSource.SearchAndFilter(this.searchBar.Text);
            this.TableView.ReloadData();
        }

    }
}

