
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeGlassesApplication.Models
{
	public class Inventory
	{
		[Key]
		public int InventoryID { get; set; }

		[Required]
		public int ProductID { get; set; }

		[ForeignKey("ProductID")]
		public Product Product { get; set; }

		[Required]
		[Range(0, int.MaxValue, ErrorMessage = "Quantity must be 0 or more.")]
		public int Quantity { get; set; }

		[Required]
		public DateTime LastUpdated { get; set; }

		// Constructor to initialize default values
		public Inventory()
		{
			LastUpdated = DateTime.Now;
		}
	}
}