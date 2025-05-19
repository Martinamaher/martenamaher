using System.ComponentModel.DataAnnotations;
using EyeGlassesApplication.Models;
public class Discount
{
	[Key]
	public int DiscountID { get; set; }

	[Required, MaxLength(100)]
	public string DiscountName { get; set; }

	[Required]
	public decimal Percentage { get; set; }

	public DateTime StartDate { get; set; }

	public DateTime EndDate { get; set; }

	public ICollection<Product> Products { get; set; }
}
