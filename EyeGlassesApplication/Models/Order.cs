using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EyeGlassesApplication.Models
{
	public class Order
	{
		[Key]
		public int OrderID { get; set; }

		[Required]
		public int UserID { get; set; }

		[ForeignKey("UserID")]
		public User User { get; set; }

		[Required]
		public DateTime OrderDate { get; set; }

		[Required]
		[MaxLength(50)]
		public string Status { get; set; }

		[Required]
		[Column(TypeName = "decimal(10, 2)")]
		public decimal TotalAmount { get; set; }

		// Navigation Properties
		public ICollection<Order_Details> OrderDetails { get; set; }
		public ICollection<Payment> Payments { get; set; }

		// Constructor to set default values
		public Order()
		{
			OrderDate = DateTime.Now;
			Status = "Pending";
			OrderDetails = new List<Order_Details>();
			Payments = new List<Payment>();
		}
	}
}