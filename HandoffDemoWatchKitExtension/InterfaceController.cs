using System;

using WatchKit;
using Foundation;

namespace HandoffDemoWatchKitExtension
{
	public partial class InterfaceController : WKInterfaceController
	{
		Vehicle[] Vehicles;
		public InterfaceController (IntPtr handle) : base (handle)
		{
		}

		public override void Awake (NSObject context)
		{
			base.Awake (context);

			// Configure interface objects here.
			Console.WriteLine ("{0} awake with context", this);
		}

		public override void WillActivate ()
		{
			// This method is called when the watch view controller is about to be visible to the user.
			Console.WriteLine ("{0} will activate", this);

			this.Vehicles = Vehicle.GetVehicles ();

			/// Setup Table in Controller.
			this.vehicleTable.SetNumberOfRows (this.Vehicles.Length, "vehicleController");

			for (int i = 0; i < this.Vehicles.Length; i++) {
				var vehicleRow = (VehicleRowController)this.vehicleTable.GetRowController (i);
				vehicleRow.Update (this.Vehicles [i]);
			}
		}

		public override void DidDeactivate ()
		{
			// This method is called when the watch view controller is no longer visible to the user.
			Console.WriteLine ("{0} did deactivate", this);
		}

		public override void DidSelectRow (WKInterfaceTable table, nint rowIndex)
		{
			base.DidSelectRow (table, rowIndex);
			this.PresentController ("vehiclePage", this.Vehicles [(int)rowIndex].VIN);
		}
	}
}

