using EyeGlassesApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Order
{
	[Key]
	public int OrderID { get; set; }

	[Required]
	[ForeignKey("User")]
	public int UserID { get; set; }

	[Required]
	public DateTime OrderDate { get; set; }

	[Required]
	[MaxLength(50)]
	public string Status { get; set; }  // مثال: Pending, Completed, Cancelled

	[Required]
	[Column(TypeName = "decimal(10, 2)")]
	public decimal TotalAmount { get; set; }

	// Navigation properties
	public User User { get; set; }
	public ICollection<OrderDetail> OrderDetails { get; set; }
	public ICollection<Payment> Payments { get; set; }

	public Order()
	{
		OrderDate = DateTime.Now;
		Status = "Pending";
	}
}