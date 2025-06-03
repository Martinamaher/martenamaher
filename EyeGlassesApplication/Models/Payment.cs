using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeGlassesApplication.Models
{
	public class Payment
	{
		[Key]
		public int PaymentID { get; set; }

		[Required]
		public int OrderID { get; set; }

		[ForeignKey("OrderID")]
		public Order Order { get; set; }

		[Required]
		[Column(TypeName = "decimal(10, 2)")]
		public decimal AmountPaid { get; set; }

		[Required]
		[MaxLength(50)]
		public string PaymentMethod { get; set; }  // مثال: Credit Card, PayPal, Cash

		[Required]
		public DateTime PaymentDate { get; set; }

		// Constructor to set default values
		public Payment()
		{
			PaymentDate = DateTime.Now;
		}
	}
}
