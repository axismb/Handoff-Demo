using System;

namespace HandoffDemo
{
	public class Vehicle
	{
		public string VIN { get; set; }				// Vehicle ID
		public string Manufacturer { get; set; }	// Vehicle Manufacturer
		public string Model { get; set; }			// Vehicle Model
		public int Year { get; set; }				// Vehicle Year


		/// <summary>
		/// Initialize new instance of Vehicle class.
		/// </summary>
		/// <param name="vin">VIN.</param>
		/// <param name="manufacturer">Manufacturer.</param>
		/// <param name="model">Model.</param>
		/// <param name="year">Year.</param>
		public Vehicle (string vin, string manufacturer, string model, int year)
		{
			this.VIN = vin;
			this.Manufacturer = manufacturer;
			this.Model = model;
			this.Year = year;
		}

		/// <summary>
		/// Get array of sample vehicles.
		/// </summary>
		/// <returns>Vehicles</returns>
		public static Vehicle[] GetVehicles()
		{
			return new Vehicle[] {
				new Vehicle("A0002Z", "Toyota", "Corolla", 2012),
				new Vehicle("Z002AP", "Saturn", "Ion", 2006),
				new Vehicle("HD3993", "Honda", "Civic", 2002)
			};
		}
	}
}

