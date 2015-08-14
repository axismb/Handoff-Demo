using System;

namespace HandoffDemo
{
	public class HandoffArgs : EventArgs
	{
		public string VIN { get; set; }

		public HandoffArgs (string vin)
		{
			this.VIN = vin;
		}
	}
}

