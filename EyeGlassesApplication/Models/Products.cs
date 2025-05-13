using EyeGlassesApplication.Models;
using System.ComponentModel.DataAnnotations;

public class Product
{
	[Key]
	public int ProductID { get; set; }

	[Required, MaxLength(150)]
	public string ProductName { get; set; }

	public string Description { get; set; }

	public decimal Price { get; set; }

	public int FrameCompanyID { get; set; }
	public FrameCompany FrameCompany { get; set; }

	public int LenseCompanyID { get; set; }
	public LenseCompany LenseCompany { get; set; }

	public int? DiscountID { get; set; }
	public Discount Discount { get; set; }

	public ICollection<Order_Details> OrderDetails { get; set; }
	public ICollection<Inventory> Inventories { get; set; }
	public ICollection<Reviews> Reviews { get; set; }
}