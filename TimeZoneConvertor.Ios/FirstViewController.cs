using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TimeZoneConvertor.Ios
{
    public partial class FirstViewController : UIViewController
    {
        private TimeZoneInfo selectedTimeZone;

        static bool UserInterfaceIdiomIsPhone {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public FirstViewController (IntPtr handle) : base (handle)
        {
            this.Title = NSBundle.MainBundle.LocalizedString ("First", "First");
            this.TabBarItem.Image = UIImage.FromBundle ("first");
            this.selectedTimeZone = TimeZoneInfo.Local;
       
           }

        public void SetSelectedTimeZoneInfo(TimeZoneInfo tz)
        {
            if (tz == null)
                tz=TimeZoneInfo.Local;

            this.selectedTimeZone = tz;
            this.selectBaseTzButton.SetTitle (this.selectedTimeZone.DisplayName, UIControlState.Normal);
        }

        public override void DidReceiveMemoryWarning ()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning ();
            
            // Release any cached data, images, etc that aren't in use.
        }
        #region View lifecycle
        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            
            this.SetSelectedTimeZoneInfo(TimeZoneInfo.Local);
			this.timeZonesTableView.Source = new TimeZonesTabeViewSource ();
			var f = this.timeZonesTableView.Frame;
			var size=new SizeF(){Width=1500, Height=f.Height};
			this.timeZonesTableView.Frame=new RectangleF(f.X,f.Y,1500,f.Height);
			//this.timeZonesTableView.ContentSize = size;
			this.timeZonesScrollView.ContentSize = size;
         
        }

        public override void ViewWillAppear (bool animated)
        {
            base.ViewWillAppear (animated);
        }

        public override void ViewDidAppear (bool animated)
        {
            base.ViewDidAppear (animated);
        }

        public override void ViewWillDisappear (bool animated)
        {
            base.ViewWillDisappear (animated);
        }

        public override void ViewDidDisappear (bool animated)
        {
            base.ViewDidDisappear (animated);
        }
        #endregion

        [Obsolete]
        public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            if (UserInterfaceIdiomIsPhone) {
                return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
            } else {
                return true;
            }
        }
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "baseTzSelectionSegue")
            {
                var target= segue.DestinationViewController as tzSelectionController;
                target.ParentController = this;
            }
        }
    }
}

