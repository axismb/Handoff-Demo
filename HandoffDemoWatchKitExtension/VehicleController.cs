using Foundation;
using System;
using System.Linq;
using System.CodeDom.Compiler;
using UIKit;

namespace HandoffDemoWatchKitExtension
{
	partial class VehicleController : WatchKit.WKInterfaceController
	{
		private Vehicle _Vehicle { get; set; }
		public VehicleController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);
			this._Vehicle = Vehicle.GetVehicles ().First (x => x.VIN == (string)(NSString)context);
		}

		public override void WillActivate ()
		{
			base.WillActivate ();
			this.textLbl.SetText (this._Vehicle.ToString () + "\nHandoff Activated.");

			/// Update User Activity to activate handoff, containing vehicle's VIN.
			NSDictionary userInfo = new NSDictionary ("VIN", this._Vehicle.VIN);
			this.UpdateUserActivity ("com.azizmb.handoffdemo.viewing", userInfo, null);
		}

		public override void DidDeactivate ()
		{
			base.DidDeactivate ();

			/// Invalidate User Activity to deactive handoff.
			this.InvalidateUserActivity();
		}
	}
}
