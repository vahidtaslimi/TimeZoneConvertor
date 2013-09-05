using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TimeZoneConvertor.Ios
{
	public partial class tzSelection : UITableViewCell
	{
		public static readonly UINib Nib = UINib.FromName ("tzSelection", NSBundle.MainBundle);
		public static readonly NSString Key = new NSString ("tzSelection");

		public tzSelection (IntPtr handle) : base (handle)
		{
		}

		public static tzSelection Create ()
		{
			return (tzSelection)Nib.Instantiate (null, null) [0];
		}
	}
}

