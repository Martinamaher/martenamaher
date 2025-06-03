using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EyeGlassesApplication.Models;

namespace EyeGlassesApplication.Models
{
	public class Order_Details
	{
		[Key]
		public int OrderDetailsID { get; set; }

		[Required]
		public int OrderID { get; set; }

		[ForeignKey("OrderID")]
		public Order Order { get; set; }

		[Required]
		public int ProductID { get; set; }

		[ForeignKey("ProductID")]
		public Product Product { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		[Column(TypeName = "decimal(10, 2)")]
		public decimal UnitPrice { get; set; }
	}
}