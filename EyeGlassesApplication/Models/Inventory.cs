
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EyeGlassesApplication.Models;
public class Inventory
{
	[Key]
	public int InventoryID { get; set; }

	[Required]
	[ForeignKey("Product")]
	public int ProductID { get; set; }

	[Required]
	public int Quantity { get; set; }

	[Required]
	public DateTime LastUpdated { get; set; }

	// Navigation property
	public Product Product { get; set; }

	// Constructor to set default values
	public Inventory()
	{
		LastUpdated = DateTime.Now;
	}
}