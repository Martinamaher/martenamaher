using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Payment
{
	[Key]
	public int PaymentID { get; set; }

	[Required]
	[ForeignKey("Order")]
	public int OrderID { get; set; }

	[Required]
	[Column(TypeName = "decimal(10, 2)")]
	public decimal AmountPaid { get; set; }

	[Required]
	[MaxLength(50)]
	public string PaymentMethod { get; set; }  // مثال: Credit Card, PayPal, Cash

	[Required]
	public DateTime PaymentDate { get; set; }

	// Navigation property to the associated order
	public Order Order { get; set; }

	public Payment()
	{
		PaymentDate = DateTime.Now;
	}
}
