// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TimeZoneConvertor.Ios
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton selectBaseTzButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIScrollView timeZonesScrollView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView timeZonesTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (selectBaseTzButton != null) {
				selectBaseTzButton.Dispose ();
				selectBaseTzButton = null;
			}

			if (timeZonesTableView != null) {
				timeZonesTableView.Dispose ();
				timeZonesTableView = null;
			}

			if (timeZonesScrollView != null) {
				timeZonesScrollView.Dispose ();
				timeZonesScrollView = null;
			}
		}
	}
}
