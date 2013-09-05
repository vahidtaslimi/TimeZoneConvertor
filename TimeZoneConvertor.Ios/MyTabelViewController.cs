using System;
using System.Drawing;

using MonoTouch.CoreFoundation;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace TimeZoneConvertor.Ios
{

    [Register("MyTabelViewController")]
    public class MyTabelViewController : UITableViewController
    {
        public MyTabelViewController()
        {
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

            // Perform any additional setup after loading the view
        }
    }
}