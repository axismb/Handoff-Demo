using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HandoffDemoWatchKitExtension
{
	partial class VehicleRowController : NSObject
	{
		public VehicleRowController (IntPtr handle) : base (handle)
		{
		}

		public void Update(Vehicle v)
		{
			this.VehicleLbl.SetText (v.ToString ());
		}
	}
}
