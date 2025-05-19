using EyeGlassesApplication.Models;
using System.ComponentModel.DataAnnotations;

public class Order_Details
{
	[Key]
	public int OrderDetailsID { get; set; }

	public int OrderID { get; set; }
	public Order Order { get; set; }

	public int ProductID { get; set; }
	public Product Product { get; set; }

	public int Quantity { get; set; }

	public decimal UnitPrice { get; set; }
}