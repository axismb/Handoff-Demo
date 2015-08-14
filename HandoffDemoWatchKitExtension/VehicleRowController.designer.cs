// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HandoffDemoWatchKitExtension
{
	[Register ("VehicleRowController")]
	partial class VehicleRowController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel VehicleLbl { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (VehicleLbl != null) {
				VehicleLbl.Dispose ();
				VehicleLbl = null;
			}
		}
	}
}
